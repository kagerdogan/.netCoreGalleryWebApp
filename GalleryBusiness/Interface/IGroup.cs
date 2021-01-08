using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using System.Linq;
namespace GalleryBusiness.Interface
{
    public interface IGroup
    {
        public IEnumerable<Group> ListOfGroup();
        public bool AddGroup(Group group);
        public bool DeleteGroup(int id);
        public Group FindGroupById(int id);
        public bool SetGroup(Group egroup);
    }
}
