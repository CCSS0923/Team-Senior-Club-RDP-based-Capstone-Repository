using System.Collections.ObjectModel;
using EduStream.Core.Common;

namespace EduStream.Server.ViewModels;

/// <summary>
/// UI 담당자가 서버 화면을 다시 설계할 수 있도록
/// 임시 테스트 UI와 데모 동작을 제거한 최소 스캐폴드 ViewModel입니다.
/// </summary>
public sealed class ServerViewModel : ObservableObject
{
    public string WindowTitle { get; } = "EduStream Server";

    public string HeaderTitle { get; } = "교수 서버 UI 스캐폴드";

    public string HeaderDescription { get; } =
        "임시 세션 대시보드, RDP 테스트 패널, 샘플 전송 UI를 모두 걷어낸 기본 화면입니다. " +
        "UI 담당은 이 브랜치에서 서버 운영 화면을 새로 구성하면 됩니다.";

    public string StatusSummary { get; } =
        "현재 이 화면은 UI 재구성을 위한 기본 틀만 제공하며, 실제 제어 로직은 서비스 계층에 남아 있습니다.";

    public ObservableCollection<string> LeftPanelNotes { get; } =
    [
        "세션 열기 / 닫기 영역",
        "교수 화면 미리보기 영역",
        "RDP 또는 송신 상태 패널",
        "참여자 상태 표시"
    ];

    public ObservableCollection<string> RightPanelNotes { get; } =
    [
        "파일 전송 영역",
        "공지 / 채팅 영역",
        "활동 로그",
        "추가 관리 패널"
    ];
}
