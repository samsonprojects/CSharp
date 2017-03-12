﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://www.codeproject.com/Articles/11155/Abstract-Class-versus-Interface
/// </summary>

namespace AbstractVInterface
{
    public class Emp_Fulltime2: IEmployee
    {
        /// 

        /// Summary description for Emp_fulltime2.


        /// 


        //Implementing the interface

        public class Emp_fulltime2 : IEmployee
        {
            //All the properties and 


            //fields are defined here!

            protected String id;
            protected String lname;
            protected String fname;

            public Emp_fulltime2()
            {
                //


                // TODO: Add constructor logic here

                //

            }

            public String ID
            {
                get

                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public String FirstName
            {
                get
                {
                    return fname;
                }
                set

                {
                    fname = value;
                }
            }

            public String LastName
            {
                get
                {
                    return lname;
                }
                set
                {
                    lname = value;
                }
            }

            //all the manipulations including Add,Delete, 


            //Search, Update, Calculate are done

            //within the object as there are not 

            //implementation in the Interface entity.

            public String Add()
            {
                return "Fulltime Employee " +
                              fname + " added.";
            }

            public String Delete()
            {
                return "Fulltime Employee " +
                            fname + " deleted.";
            }

            public String Search()
            {
                return "Fulltime Employee " +
                           fname + " searched.";
            }

            public String Update()
            {
                return "Fulltime Employee " +
                            fname + " updated.";
            }

            //if you change to Calculatewage(). 


            //Just small 'w' it will raise 

            //error as in interface

            //it is CalculateWage() with capital 'W'.

            public String CalculateWage()
            {
                return "Full time employee " +
                      fname + " caluculated using " +
                      "Interface.";
            }

        }
}
