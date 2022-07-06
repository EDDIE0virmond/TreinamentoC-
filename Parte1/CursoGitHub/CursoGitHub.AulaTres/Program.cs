using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.insertion(1.90, "Sherry");
            dog.insertion(1.80, "Zoe");
        }
    }
    public class Dogs 
    {
        private Dog headDog;
        private Dog root;
        internal class Dog 
        {
            private Dog rightDog;
            private Dog leftDog;
            private Dog upDog;
            private Dog beforeUpDog;
            private string name_m;
            private double height_m;

            internal Dog BeforeUpDog { get => beforeUpDog; set => beforeUpDog = value; }
            internal Dog RightDog { get => rightDog; set => rightDog = value; }
            internal Dog LeftDog { get => leftDog; set => leftDog = value; }
            internal Dog UpDog { get => upDog; set => upDog = value; }

            public Dog(string name, double height) 
            {
                this.name_m = name;
                this.height_m = height;

            }
            public void SetName(string name) 
            {
                this.name_m = name;
            }
            public void SetHeight(double height) 
            {
                this.height_m = height;  
            }
            public string GetName() 
            {
                return this.name_m;
            }
            public double GetHeight() 
            {
                return this.height_m;
            }

        }
        public void insertion(double height, string name) 
        {
            Dog aux = new Dog(name, height);
            if (headDog == null)
            {
                headDog = aux;
                root = aux;
                headDog.UpDog = null;
                headDog.BeforeUpDog = null;
            }
            else 
            {
                Dog father = headDog.UpDog;
                if (headDog.UpDog == null) 
                {
                    father = null;
                }
                Dog node = headDog;
                while (true) 
                {
                    if (aux.GetHeight() < node.GetHeight())
                    {
                        node = node.LeftDog;
                        if (node == null) 
                        {
                            father.LeftDog = aux;
                            aux.UpDog = father;
                            if (aux.BeforeUpDog == null)
                            {
                                aux.BeforeUpDog = father.UpDog;
                            }
                            return;
                        }
                    }
                    else 
                    {
                        node = node.RightDog;
                        if (node == null)
                        {
                            father.RightDog = aux;
                            aux.UpDog = father;
                            if (aux.BeforeUpDog == null) 
                            {
                                aux.BeforeUpDog = father.UpDog;
                            }
                            return;
                        }
                    }
                }
            }
        }
    }
}
