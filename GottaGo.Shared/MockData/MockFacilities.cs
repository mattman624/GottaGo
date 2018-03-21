using GottaGo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GottaGo.Shared.MockData
{
    public class MockFacilities
    {
        static List<Facility> _facilities;

        static MockFacilities()
        {
            _facilities = new List<Facility>();
            _facilities.AddRange(
                new[] { new Facility()
                    {
                        Id = 1,
                        Name = "First",
                        OpenToPublic = true
                    },
                    new Facility(){
                        Id = 2,
                        Name = "Second",
                        OpenToPublic = false
                    }
                }            
            );
        }

        public static List<Facility> GetAll()
        {
            return _facilities;
        }

    }
}
