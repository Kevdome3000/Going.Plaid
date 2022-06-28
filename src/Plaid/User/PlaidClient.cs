namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint should be called for each of your end users before they begin a Plaid income flow. This provides you a single token to access all income data associated with the user. You should only create one per end user.</para>
	/// <para>If you call the endpoint multiple times with the same client_user_id, the first creation call will succeed and the rest will fail with an error message indicating that the user has been created for the given client_user_id.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#usercreate" /></remarks>
	public Task<User.UserCreateResponse> UserCreateAsync(User.UserCreateRequest request) =>
		PostAsync("/user/create", request)
			.ParseResponseAsync<User.UserCreateResponse>();
}