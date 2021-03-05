using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp {
    abstract class StorageManager {
        protected string connector;
        public abstract void init(string arg);

        public abstract bool save(ClientInfo client);

        public abstract List<ClientInfo> collectClients();
    }
}
