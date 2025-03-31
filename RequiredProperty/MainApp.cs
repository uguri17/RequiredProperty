namespace RequiredProperty
{
    class BirthdayInfo // Step 1. 설계도를 작성해보자
    {
        // 생일 정보를 담을 객체를 만들건데
        // 뭔가 필드로 이름, 생년월일 필요할 거 같은데
        // 이름은 바뀔 수 있으니 get; set;
        // 생년월일은 불변이니 get; init;
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }        
    
    class MainApp
    {
        static void Main(string[] args)
        {
            // required를 수식해서 그런 지
            // 객체를 생성하면서 초기화할 때 필수사항이라고 알림창이 뜬다.
            BirthdayInfo bi = new BirthdayInfo() { Name = "kdw", Birthday = new DateTime(2000, 12, 16) };
            Console.WriteLine($"{bi.Name}, {bi.Birthday}");
        }
    }
}
