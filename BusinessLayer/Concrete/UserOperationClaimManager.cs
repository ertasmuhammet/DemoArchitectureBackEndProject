using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal _userOperationClaimDal)
        {
            userOperationClaimDal = _userOperationClaimDal;
        }

        public void Add(UserOperationClaim userOperationClaim)
        {
            userOperationClaimDal.Add(userOperationClaim);
        }
    }
}
