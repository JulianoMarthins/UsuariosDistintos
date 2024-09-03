using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosDistintos.entities {
    internal class LogRecord {

        public string UserName { get; set;}
        public DateTime Instant { get; set;}


        public LogRecord(string userName, DateTime instant) {
            UserName = userName;
            Instant = instant;
        }


        public override int GetHashCode() {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj) {
            
            if(!(obj is LogRecord)) {
                return false;
            }

            LogRecord other = obj as LogRecord;
            
            return UserName.Equals(other.UserName);
        }

        public override string ToString() {
            return $"{UserName}: {Instant}";
        }

    }
}
