using MyRequest = SerenityTestReact.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenityTestReact.Administration.UserRow>;
using MyRow = SerenityTestReact.Administration.UserRow;

namespace SerenityTestReact.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}