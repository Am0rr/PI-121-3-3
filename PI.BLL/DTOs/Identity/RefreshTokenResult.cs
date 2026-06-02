namespace PI.BLL.DTOs.Identity;

public record RefreshTokenResult(
    string Token,
    DateTime ExpiresAt
);