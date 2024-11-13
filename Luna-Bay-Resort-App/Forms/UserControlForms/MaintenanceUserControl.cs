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
            Panel availableRoomsPanel = CreateRoomPanel("Room : List of Available", new string[] { "Room No.", "Room Type" });
            mainPanel.Controls.Add(availableRoomsPanel, 0, 0);

            // Cleaning & Inspection panel
            Panel cleaningPanel = CreateRoomPanel("Room : Cleaning & Inspection", new string[] { "Room No."}, true);
            mainPanel.Controls.Add(cleaningPanel, 1, 0);

            // For Repair panel
            Panel repairPanel = CreateRoomPanel("Room : For Repair", new string[] { "Room No." }, true);
            mainPanel.Controls.Add(repairPanel, 2, 0);

            this.Controls.Add(mainPanel);


            //Insert availabler rooms onto availableRoomsPanel
            var AvailableRoomTable = (DataGridView)availableRoomsPanel.Controls[0].Controls[2];
            PopulateAvailableRooms(AvailableRoomTable);

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
                RowHeadersVisible = false
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
            }

            layoutPanel.Controls.Add(roomTable, 0, 2);

            containerPanel.Controls.Add(layoutPanel);
            return containerPanel;
        }


        //Method for populating availble rooms
        private void PopulateAvailableRooms(DataGridView roomTable)
        {
            List<Accommodation> availableRooms= DatabaseHelper.GetAllAvailableRoom(roomTable);
            foreach (var room in availableRooms)
            {
                roomTable.Rows.Add(room.GetRoomId(), room.GetName());
            }
        }

        //Method to be used for CleaningPanel
        private void PopulateCleaningandInspection(DataGridView roomTable)
        {
            List<Accommodation> notavailableRooms = DatabaseHelper.GetAllNotAvaialbleRoom(roomTable);
            foreach (var room in notavailableRooms)
            {
                roomTable.Rows.Add(room.GetRoomId(), room.GetName());
            }
        }

    }
}
