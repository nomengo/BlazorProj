namespace BlazorStajApplication.Application.Commands
{
    public class CreateEmployeeCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public string Department { get; set; }
        //public List<AttributeDto> Attributes { get; set; }  // Attribute'ler için DTO

        /*
        public class AttributeDto
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }
        */
    }
}
