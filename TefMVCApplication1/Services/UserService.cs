using TefMVCApplication1.DBModels;
using TefMVCApplication1.ViewModels;

namespace TefMVCApplication1.Services
{
    public class UserService
    {
        TefProjectContext context=new TefProjectContext();
        
        public List<UserVM> GetUserList() 
        {
            var list = context.Users.ToList();
            var result = new List<UserVM>();
            foreach (var user in list)
            {
                var vm= new UserVM();
                vm.Id = user.Id;
                vm.Name = user.Name;
                vm.LastName = user.LastName;
                vm.Province = user.Province;
                vm.FullName=user.Name+" "+user.LastName;
                result.Add(vm);
            }

            return result;
        }   
        
        public void CreateUser(UserVM vm)
        {
            User userModel=new User();
            userModel.Id = vm.Id;
            userModel.Name = vm.Name;       
            userModel.LastName = vm.LastName;
            userModel.Province = vm.Province;
            context.Users.Add(userModel);
            context.SaveChanges();
            
        }
    }
}
