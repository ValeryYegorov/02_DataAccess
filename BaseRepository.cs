using Contracts;

namespace DataAccess;

public class BaseRepository : IBaseRepository
{
    public HelloReply GetHelloReplyTest(string requestName)
    {
        return new HelloReply
        {
            Message = "Hello " + requestName
        };
    }
}