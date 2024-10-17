interface IRegisterService{
    public bool Login(Login login, List<Register> regdb);
    public bool RegisterUser(Register register, List<Register> regdb);
    public List<Register> getAllUser(List<Register> regdb);
    public Register? getUser(int Id, List<Register> regdb);
}
