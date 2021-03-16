using System;
using System.Collections;
using System.Text;

namespace ComparableDemo
{
    public class User : IComparable
    {

        private class sortDateOfBirthHelper : IComparer {

            int IComparer.Compare(object x, object y) {
                User u1 = (User)x;
                User u2 = (User)y;

                if (u1.dateOfBirth > u2.dateOfBirth) {
                    return 1;
                }

                if (u1.dateOfBirth < u2.dateOfBirth)
                {
                    return -1;
                }

                else {
                    return 0;
                }
            }
        }

        int IComparable.CompareTo(object obj) {
            User user1 = (User)obj;
            return String.Compare(this.name, user1.name);
        }

        public string name { get; set; }

        public int dateOfBirth { get; set; }

        public User(string name, int dateOfBirth) {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public static IComparer sortDateOfBirth() {

            return (IComparer)new sortDateOfBirthHelper();
        }

    }
}
