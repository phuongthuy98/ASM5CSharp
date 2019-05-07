using System;
using System.Collections.Generic;
using System.Text;

namespace ASM5CSharp
{
    interface Phone
    {
        void insertPhone(String name, String phone);
        void removePhone(String name);
        void updatePhone(String name, String newphone);
        void searchPhone(String name);
    }
}