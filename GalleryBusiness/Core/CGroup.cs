using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using System.Linq;
using GalleryBusiness.Interface;

namespace GalleryBusiness.Core
{
    public class CGroup : IGroup
    {
        private GalleryContext gc = new GalleryContext();

        public bool AddGroup(Group group)
        {
            gc.Add(group);
            gc.SaveChanges();
            return true;
        }

        public bool DeleteGroup(int id)
        {
            var deleted = gc.Groups.FirstOrDefault(c => c.Gid == id);
            gc.Groups.Remove(deleted);
            gc.SaveChanges();
            return true;
        }

        public Group FindGroupById(int id)
        {
            var group = gc.Groups.Where(c => c.Gid == id).Select(c => c).FirstOrDefault();
            return group;
        }

        public IEnumerable<Group> ListOfGroup()
        {
            var grplist = gc.Groups.Select(c => c).ToList();
            return grplist;
        }

        public bool SetGroup(Group egroup)
        {
            var updated = gc.Groups.Where(c => c.Gid == egroup.Gid)
                .Select(c => c).FirstOrDefault();
            updated.Gid = egroup.Gid;
            updated.Gname = egroup.Gname;
            updated.Ginfo = egroup.Ginfo;
            gc.Groups.Update(updated);
            gc.SaveChanges();
            return true;
        }
    }
}
