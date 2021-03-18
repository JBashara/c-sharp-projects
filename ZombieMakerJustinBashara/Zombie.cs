using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ZombieMakerJustinBashara
{
    [Serializable]
    class Zombie
    {
        String name, groan;
        public Zombie loadZombie;


        public Zombie() { }
        
        public Zombie(String name, String groan)
        {
            this.name = name;
            this.groan = groan;
        }

        public void update(Zombie zombie)
        {
            this.name = zombie.name;
            this.groan = zombie.groan;
        }

        public String toString()
        {
            String display = this.name + " says: " + this.groan + ".";
            return display;
        }

        public static void saveTheFile(String fileName, Zombie zombie)
        {
            using (Stream output = File.Create(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, zombie);
            }
        }
        
        public Zombie openTheFile(String fileName)
        {
            using (Stream input = File.OpenRead(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                loadZombie = (Zombie) formatter.Deserialize(input);
                
            }
            return loadZombie;
        }
    }
}
