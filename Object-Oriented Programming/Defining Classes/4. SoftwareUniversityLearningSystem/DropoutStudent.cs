using System;

public class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.DropoutReason = dropoutReason;
    }

    public string DropoutReason
    {
        get
        {
            return this.dropoutReason;
        }
        set
        {
            this.dropoutReason = value;
        }
    }

    public string Reapply()
    {
        return base.ToString() + Environment.NewLine + "Dropout reason: " + this.DropoutReason;
    }
}
