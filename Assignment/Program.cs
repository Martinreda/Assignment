using Assignment.Interface;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            
            
                ICircle myCircle = new Circle(5.0);
                IRectangle myRectangle = new Rectangle(4.0, 6.0);

                myCircle.DisplayShapeInfo();      
                myRectangle.DisplayShapeInfo();  
           
            #endregion
        }
    }
}
