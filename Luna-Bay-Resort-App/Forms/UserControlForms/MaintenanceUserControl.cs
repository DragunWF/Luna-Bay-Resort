using Luna_Bay_Resort_App.Data;
using Luna_Bay_Resort_App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForms
{
    public partial class MaintenanceUserControl : UserControl
    {
        private Panel availableRoomsPanel;
        private Panel cleaningPanel;
        private Panel repairPanel;

        public MaintenanceUserControl()
        {
            InitializeComponent();
            InitializeMaintenanceLayout();
        }
        private void InitializeMaintenanceLayout()
        {
            // Main panel for layout
            TableLayoutPanel mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                Padding = new Padding(10),
            };

            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33)); // Room: List of Available
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33)); // Room: Cleaning & Inspection
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33)); // Room: For Repair

            // Available Rooms panel
            availableRoomsPanel = CreateRoomPanel("Room : List of Available", new string[] { "Room No.", "Room Type" });
            mainPanel.Controls.Add(availableRoomsPanel, 0, 0);

            // Cleaning & Inspection panel
            cleaningPanel = CreateRoomPanel("Room : Cleaning & Inspection", new string[] { "Room No."}, true);
            mainPanel.Controls.Add(cleaningPanel, 1, 0);

            // For Repair panel
            repairPanel = CreateRoomPanel("Room : For Repair", new string[] { "Room No." }, true);
            mainPanel.Controls.Add(repairPanel, 2, 0);

            this.Controls.Add(mainPanel);


            //Insert "Available" rooms onto availableRoomsPanel
            var AvailableRoomTable = (DataGridView)availableRoomsPanel.Controls[0].Controls[2];
            PopulateAvailableRooms(AvailableRoomTable);

            //Insert "Cleaning" rooms onto cleaningPanel
            var CleaningRoomTable = (DataGridView)cleaningPanel.Controls[0].Controls[2];
            String cleaningstatus = "Cleaning";
            PopulateNotAvailbeRooms(CleaningRoomTable, cleaningstatus);

            //Insert "Repair" rooms onto repairPanel
            var RepairRoomTable = (DataGridView)repairPanel.Controls[0].Controls[2];
            String repairstatus = "Repair";
            PopulateNotAvailbeRooms(RepairRoomTable, repairstatus);

        }

        private Panel CreateRoomPanel(string title, string[] columns, bool includeStatusComboBox = false)
        {
            
            Panel containerPanel = new Panel { Dock = DockStyle.Fill };

            
            TableLayoutPanel layoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1
            };

            layoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); 
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10)); 
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); 

            
            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Consolas", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 0)
            };
            layoutPanel.Controls.Add(titleLabel, 0, 0);

            
            Panel spacerPanel = new Panel
            {
                Height = 100, 
                Dock = DockStyle.Top
            };
            layoutPanel.Controls.Add(spacerPanel, 0, 1);

            
            DataGridView roomTable = new DataGridView
            {
                Font = new Font("Consolas", 12, FontStyle.Regular),
                Dock = DockStyle.Fill,
                ColumnHeadersVisible = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                ScrollBars = ScrollBars.Both,
            };

           
            roomTable.Columns.Clear();

            
            foreach (var column in columns)
            {
                roomTable.Columns.Add(column, column);
            }

            
            if (includeStatusComboBox && roomTable.Columns["ChangeStatus"] == null)
            {
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
                {
                    Name = "ChangeStatus",
                    HeaderText = "Change Status",
                    DataSource = new string[] { "Available", "Cleaning", "Repair" },
                    FlatStyle = FlatStyle.Flat
                };
                roomTable.Columns.Add(statusColumn);

                //Event for when combo box value is changed
                
                roomTable.CellValueChanged += (sender, e) =>
                {
                    int roomId = Convert.ToInt32(roomTable.Rows[e.RowIndex].Cells["Room No."].Value);
                    string newStatus = roomTable.Rows[e.RowIndex].Cells["ChangeStatus"].Value.ToString();
                    DatabaseHelper.SetRoomStatus(newStatus, roomId);
                    
                    RefreshRoomData();
                };
            }

            layoutPanel.Controls.Add(roomTable, 0, 2);

            containerPanel.Controls.Add(layoutPanel);
            return containerPanel;

        }


        //Method for populating available rooms
        private void PopulateAvailableRooms(DataGridView roomTable)
        {
            List<Accommodation> availableRooms= DatabaseHelper.GetAvailableRoom(roomTable);
            foreach (var room in availableRooms)
            {
                roomTable.Rows.Add(room.GetRoomId(), room.GetName());
            }
        }

        //Method for populating by room status
        private void PopulateNotAvailbeRooms(DataGridView roomTable, string roomStatus)
        {
            List<Accommodation> notavailableRooms = DatabaseHelper.GetNotAvailableRoom(roomTable, roomStatus);
            foreach (var room in notavailableRooms)
            {
                roomTable.Rows.Add(room.GetRoomId(), room.GetName());
            }
        }

        //Method for refreshing all datagridviews
        private void RefreshRoomData()
        {
            var availableRoomTable = (DataGridView)availableRoomsPanel.Controls[0].Controls[2];
            var cleaningRoomTable = (DataGridView)cleaningPanel.Controls[0].Controls[2];
            var repairRoomTable = (DataGridView)repairPanel.Controls[0].Controls[2];

            availableRoomTable.Rows.Clear();
            cleaningRoomTable.Rows.Clear();
            repairRoomTable.Rows.Clear();

            PopulateAvailableRooms(availableRoomTable);

            string cleaningStatus = "Cleaning";
            PopulateNotAvailbeRooms(cleaningRoomTable, cleaningStatus);

            string repairStatus = "Repair";
            PopulateNotAvailbeRooms(repairRoomTable, repairStatus);
        }

    }
}
