using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 简单进销存对账.DB
{
    internal class TbSupplier
    {
        private int mID;
        private String name;
        private String contact;
        private String tel;
        private String address;
        private DateTime inday;
        private DateTime upday;

        public int MID {
            get; 
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Contact
        {
            get;
            set;
        }

        public String Tel
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public DateTime Inday
        {
            get;
            set;
        }

        public DateTime Upday
        {
            get;
            set;
        }
    }
}
