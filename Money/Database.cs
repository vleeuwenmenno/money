using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Money
{
    public class Database
    {
        public string name { get; set; }

        public List<Account> accounts { get; set; }

        public List<string> payees { get; set; }

        public bool syncWebDav { get; set; }
        public bool darkTheme { get; set; }

        public string webDavHost { get; set; }
        public string webDavUsername { get; set; }
        public string webDavPass {get;set;}

        public int AccountIdFromName(string name)
        {
            int i = 0;
            foreach (Account s in accounts)
            {
                if (s.accountName == name)
                    return i;

                i++;
            }
            throw new KeyNotFoundException("Couldn't find any account with this name.");
        }

        public Database()
        {
            accounts = new List<Account>();
            name = "Database-" + DateTime.Now.Year;
            syncWebDav = false;
        }

        public Database(string path)
        {
            Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(path));

            this.accounts = db.accounts;
            this.name = db.name;

            this.syncWebDav = db.syncWebDav;
            this.webDavHost = db.webDavHost;
            this.webDavUsername = db.webDavUsername;
            this.webDavPass = db.webDavPass;

            this.darkTheme = db.darkTheme;
            this.payees = db.payees;

            foreach (Account ac in this.accounts)
                ac.RecalculateBalance();
        }

        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
