namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a bank employment verification in Link.</para>
/// </summary>
public record CreditSessionBankEmploymentResult
{
	/// <summary>
	/// <para>Status of the Bank Employment Link session.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.CreditSessionBankEmploymentStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Institution ID associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;
}