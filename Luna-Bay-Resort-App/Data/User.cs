namespace Luna_Bay_Resort_App.Data
{
    internal class User
    {
        private string empId, position, name;
        private int authId;

        public User(string empId, string position, string name, int authId)
        {
            this.empId = empId;
            this.position = position;
            this.name = name;
            this.authId = authId;
        }

        #region Getter Methods

        public string getEmpId() => empId;
        public string getPosition() => position;
        public string getName() => name;
        public int getAuthId() => authId;

        #endregion
    }
}
