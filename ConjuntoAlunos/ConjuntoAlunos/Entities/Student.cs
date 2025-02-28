namespace ConjuntoAlunos.Entities
{
    struct Student
    {
        public int Code { get; set; }

        public Student(int code) : this()
        {
            Code = code;
        }
    }
}
