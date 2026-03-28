using System.Collections.ObjectModel;
using EduStream.Core.Common;

namespace EduStream.Client.ViewModels;

/// <summary>
/// UI 담당자가 클라이언트 화면을 다시 구성할 수 있도록
/// 임시 동작을 제거하고 최소 스캐폴드만 남긴 ViewModel입니다.
/// </summary>
public sealed class ClientViewModel : ObservableObject
{
    public string WindowTitle { get; } = "EduStream Client";

    public string HeaderTitle { get; } = "학생 클라이언트 UI 스캐폴드";

    public string HeaderDescription { get; } =
        "임시 데모 UI와 테스트 동작을 제거한 기본 화면입니다. " +
        "UI 담당은 이 브랜치에서 레이아웃과 바인딩 구조를 새로 구성하면 됩니다.";

    public string StatusSummary { get; } =
        "현재 이 화면은 기능 테스트용 대시보드가 아니라 UI 재구성용 기본 토대입니다.";

    public ObservableCollection<string> LeftPanelNotes { get; } =
    [
        "세션 연결 상태 표시",
        "공유 화면 표시 영역",
        "파일 다운로드 진행률",
        "오류 메시지 및 안내 문구"
    ];

    public ObservableCollection<string> RightPanelNotes { get; } =
    [
        "채팅 목록",
        "채팅 입력창",
        "활동 로그",
        "추가 보조 패널"
    ];
}
