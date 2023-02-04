namespace Lab4
{
    struct Employee
    {
        public string FIO;//ФИО
        public string Post;// Должность
        public string Date_of_Birth;// ДАта рождения
        public string Degree; //Ученая степеть
        public int Experience;//Стажработы

        //конструктор
        public Employee(string f, string p, string d, string deg, int e)
        {
            FIO = f;
            Post = p;
            Date_of_Birth = d;
            Degree = deg;
            Experience = e;
        }
    }
}
