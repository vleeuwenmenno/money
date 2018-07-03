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

        public string webDavHost { get; set; }
        public string webDavUsername { get; set; }
        public string webDavPass {get;set;}

        public DateTime modDateTime { get; set; }

        public List<Category> categories { get; set; }

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
            
            this.payees = db.payees;
            this.modDateTime = db.modDateTime;

            foreach (Account ac in this.accounts)
                ac.RecalculateBalance();
        }

        public void Save(string path)
        {
            if (File.Exists(path))
            {
                if (JsonConvert.SerializeObject(this, Formatting.Indented) == File.ReadAllText(path))
                    return;
                else
                {
                    modDateTime = DateTime.Now;
                    string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                    File.WriteAllText(path, json);
                }
            }
            else
            {
                modDateTime = DateTime.Now;
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(path, json);
            }
        }
    }
}
