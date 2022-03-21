using System;
using Data.DB;
using Data.Entities;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands
{
    class SaveUser
    {
        public void Execute()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Ingrese el codigo de acceso de usuario: ");
            string id= Console.ReadLine();
            int IDnum = int.Parse(id);
            Console.WriteLine("Ingrese el nombre del nuevo usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del nuevo usuario: ");
            string apellido = Console.ReadLine();

            // agregar en una base de datos local
            LocalMemoryDB.MembersContext.Add(new Member() { ID = IDnum, FirstName = nombre, SecondName = apellido });
        }
    }
}
