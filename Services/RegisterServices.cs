

class RegisterServices : IRegisterService
{
    public List<Register> getAllUser(List<Register> regdb)
    {
        return regdb.ToList();
    }

    public Register? getUser(int Id, List<Register> regdb)
    {
        return regdb.Where(r=>r.Id==Id).FirstOrDefault();
        
    }

    public bool Login(Login login, List<Register> regdb)
    {
        if(login.Email != ""){
            var data = regdb.Where(r=>r.Email==login.Email && r.Password==login.Password).FirstOrDefault();

            if(data != null){
                return true;
            }else{
                return false;
            }
        }else{
            var data = regdb.Where(r=>r.Email==login.Username && r.Password==login.Password).FirstOrDefault();

            if(data != null){
                return true;
            }else{
                return false;
            }
        }
    }

    public bool RegisterUser(Register register, List<Register> regdb)
    {
        regdb.Add(register);
        return true;
    }
}