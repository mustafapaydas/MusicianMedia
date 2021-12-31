using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class GroupManager:IGroupService
    {
        private IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _groupDal = groupDal;
        }

        public IDataResult<List<Group>> GetAll()
        {
            return new SuccessDataResult<List<Group>>(_groupDal.GetAll(),Messages.Listed);
        }

        public IResult Add(Group group)
        {
           _groupDal.Add(group);
           return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Group @group)
        {
            _groupDal.Delete(group);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Group @group)
        {
            _groupDal.Update(group);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Group> GetById(int groupId)
        {
            return new SuccessDataResult<Group>(_groupDal.Get(group => group.GroupId == groupId));
        }
    }
}
