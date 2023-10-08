using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgottenMemoriesFusions
{
    class Cards
    {
        private string name;
        private string type;
        private int atk;
        private int def;

        public Cards() { }

        public Cards(Cards card)
        {
            this.name = card.name;
            this.type = card.type;
            this.atk = card.atk;
            this.def = card.def;
        }

        public void setName(string _name)
        {
            name = _name;
        }

        public void setType(string _type)
        {
            type = _type;
        }

        public void setAtk(int _atk)
        {
            atk = _atk;
        }

        public void setDef(int _def)
        {
            def = _def;
        }

        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

        public int getAtk()
        {
            return atk;
        }

        public int getDef()
        {
            return def;
        }
    }
}
