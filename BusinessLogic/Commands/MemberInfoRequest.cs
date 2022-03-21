using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System;
namespace BusinessLogic.Commands
{
    class MemberInfoRequest
    {
        public void Execute()
        {
            MemberInfoView view = new MemberInfoView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);

            Member member = new MemberRepository().GetMember(entity.ID);
            try
            {
                view.ShowResult(member.FirstName + " " + member.SecondName);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("el codigo ingresado no existe en el sistema");
            }
            
        }
    }
}
