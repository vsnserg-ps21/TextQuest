namespace TextQuest
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // ������� ��� ���������
            Character character1 = new Character("�������", 100, "���");
            Character character2 = new Character("�����", 50, "����������");
            Character character3 = new Character("��������", 75, "���");

            // ���� ������� ��������� ��������� ��������
            character1.DoAction();
            character2.DoAction();
            character3.DoAction();
        }
    }
}