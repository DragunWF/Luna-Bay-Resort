namespace Luna_Bay_Resort_App.Helpers
{
    internal static class FormManager
    {
        private static readonly Dictionary<Type, Form> _openForms = new Dictionary<Type, Form>();

        public static void OpenForm<TForm>(params object[] parameters) where TForm : Form
        {
            Type formType = typeof(TForm);

            if (_openForms.ContainsKey(formType))
            {
                _openForms[formType].BringToFront();
            }
            else
            {
                // Create an instance of the form with parameters passed to the constructor
                TForm formInstance = (TForm)Activator.CreateInstance(formType, parameters);
                formInstance.FormClosed += (sender, args) => _openForms.Remove(formType);
                _openForms[formType] = formInstance;
                formInstance.Show();
            }
        }

        public static bool IsFormOpen<TForm>() where TForm : Form
        {
            return _openForms.ContainsKey(typeof(TForm));
        }

        public static void CloseForm<TForm>() where TForm : Form
        {
            Type formType = typeof(TForm);
            if (_openForms.TryGetValue(formType, out Form form))
            {
                form.Close();
            }
        }

        public static void CloseAllForms()
        {
            foreach (var form in _openForms.Values.ToList())
            {
                form.Close();
            }
            _openForms.Clear();
        }
    }
}
