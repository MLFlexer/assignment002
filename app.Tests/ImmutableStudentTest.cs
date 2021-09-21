using System;
using System.ComponentModel;
using System.Reflection;
using Xunit;

namespace app.Tests
{
    public class ImmutableStudentTest
    {
        [Fact]
        public void Constructor()
        {
            //Arrange
            int id = 1;
            string GivenName = "givenname";
            string Surname = "surname";
            DateTime startDate = new DateTime(2020, 8, 24);
            DateTime endDate = new DateTime(2023, 6, 25);
            DateTime graduationDate = new DateTime(2023, 6, 26);
            
            
            //Act
            ImmutableStudent student = new ImmutableStudent(1, "givenname", "surname", new DateTime(2020, 8, 24), new DateTime(2023, 6, 25), new DateTime(2023, 6, 26));
            
            
            //Assert
            Assert.Equal(id, student.Id);
            Assert.Equal(GivenName, student.GivenName);
            Assert.Equal(Surname, student.SurName);
            Assert.Equal(startDate, student.StartDate);
            Assert.Equal(endDate, student.EndDate);
            Assert.Equal(graduationDate, student.GraduationDate);
        }

        [Fact]
        public void ImmutableStudent_equal()
        {
            //Arrange
            int id = 1;
            string GivenName = "givenname";
            string Surname = "surname";
            DateTime startDate = new DateTime(2020, 8, 24);
            DateTime endDate = new DateTime(2023, 6, 25);
            DateTime graduationDate = new DateTime(2023, 6, 26);
            
            
            //Act
            ImmutableStudent student1 = new ImmutableStudent(1, "givenname", "surname", new DateTime(2020, 8, 24), new DateTime(2023, 6, 25), new DateTime(2023, 6, 26));
            ImmutableStudent student2 = student1 with { };
            ImmutableStudent student3 = student1 with {Id = 3};
            
            
            //Assert
            Assert.Equal(student1, student2);
            Assert.NotEqual(student1, student3);
        }
        
        [Fact]
        public void ImmutableStudent_toString()
        {
            //Arrange
            int id = 1;
            string GivenName = "givenname";
            string Surname = "surname";
            DateTime startDate = new DateTime(2020, 8, 24);
            DateTime endDate = new DateTime(2023, 6, 25);
            DateTime graduationDate = new DateTime(2023, 6, 26);

            //Act
            ImmutableStudent student = new ImmutableStudent(1, "givenname", "surname", new DateTime(2020, 8, 24), new DateTime(2023, 6, 25), new DateTime(2023, 6, 26));
            string str = student.ToString();
            //Assert
            Assert.Equal("ImmutableStudent { Id = 1, GivenName = givenname, SurName = surname, StartDate = 24-08-2020 00:00:00, EndDate = 25-06-2023 00:00:00, GraduationDate = 26-06-2023 00:00:00, Status = Active }", str);
        }
    }
}