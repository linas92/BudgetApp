namespace BudgetApp.Data
{
    public class BudgetService
    {
        //denied the access to the "database"
        private static List<Entry> mockDataBase = new List<Entry>();

        public async Task<bool> AddEntry(Entry newEntry)
        {
            mockDataBase.Add(newEntry);
            return true;
        }
        //getting the entries from the "database" with an async task list
        public async Task<List<Entry>> GetAllEntries()
        {
            return mockDataBase;
        }

    }
}

