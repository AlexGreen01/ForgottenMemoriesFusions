using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgottenMemoriesFusions
{
    [Serializable]
    class Fusions
    {
        private string name;
        private string[] material1;
        private string[] material2;

        public Fusions() { }

        public void setName(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }

        public void setMat1(string[] _mat1)
        {
            material1 = _mat1;
        }

        public string[] getMat1()
        {
            return material1;
        }

        public void setMat2(string[] _mat2)
        {
            material2 = _mat2;
        }

        public string[] getMat2()
        {
            return material2;
        }
    }
}
