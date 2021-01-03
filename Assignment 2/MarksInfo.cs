namespace WebApplication1
{
    internal class MarksInfo
    {
        private int subjectMarksObtained;
        internal string subjectName;

        internal int SubjectMarksObtained { get => SubjectMarksObtained1; set => SubjectMarksObtained1 = value; }
        public int SubjectMarksObtained1 { get => subjectMarksObtained; set => subjectMarksObtained = value; }
    }
}