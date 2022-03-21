﻿using Data.DB;
using Data.Entities;
using System;
namespace Data
{
    public class MemberRepository
    {
        public MemberRepository()
        {
            this.GenerateFakeData();
        }

        private void GenerateFakeData()
        {            
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5000, FirstName = "Juan", SecondName = "Perez" });
            LocalMemoryDB.MembersContext.Add(new Member() { ID = 5001, FirstName = "Pedro", SecondName = "Flores" });
        }

        public Member GetMember(int id)
        {
            foreach(Member item in LocalMemoryDB.MembersContext)
            {
                if (item.ID == id)
                {
                    return item;
                }
                //else { Console.WriteLine("el codigo ingresado no existe en el sistema"); }

            }

            return null;
        }
    }
}
