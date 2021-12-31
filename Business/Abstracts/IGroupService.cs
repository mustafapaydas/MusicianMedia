using System.Collections.Generic;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IGroupService
    {
        IDataResult<List<Group>> GetAll();
        IResult Add(Group group);
        IResult Delete(Group group);
        IResult Update(Group group);
        IDataResult<Group> GetById(int groupId);

    }
}