---
lab:
    title: '랩: 수개 국어 데이터 솔루션 생성'
    type: '답변 키'
    module: '모듈 3: Azure 스토리지용 개발'
---

# 랩: 수개 국어 데이터 솔루션 생성
# 학생 랩 답변 키

## Microsoft Azure 사용자 인터페이스

Microsoft 클라우드 도구의 동적 특성을 감안할 때 이 교육 콘텐츠의 개발 후 Azure 사용자 인터페이스(UI) 변경 사항이 발생할 수 있습니다. 이러한 변경으로 인해 랩 지침 및 단계가 올바르게 일치하지 않을 수 있습니다.

Microsoft 는 커뮤니티에서 필요한 변경 사항을 가져오는 즉시 이 교육 과정을 업데이트합니다. 그러나 클라우드 업데이트가 자주 이루어지기 때문에 이 교육 콘텐츠가 업데이트되기 전에 UI가 변경될 수 있습니다. **이 경우 변경 사항에 적응하고 필요에 따라 랩에서 작업합니다.**

## 지침

### 시작하기 전에

#### 랩 가상 머신에 로그인

다음 자격 증명을 사용하여 **Windows 10** 가상 머신에 로그인합니다.
    
-   **사용자 이름**: Admin

-   **암호**: Pa55w.rd

> **참고**: 랩 가상 기계 로그인 지침은 교수자가 제공합니다.

#### 설치된 응용 프로그램 검토

**Windows 10** 바탕 화면 하단에 있는 작업 표시줄을 살펴봅니다. 작업 표시줄에는 이 랩에서 사용할 응용 프로그램에 대한 아이콘이 포함되어 있습니다.
    
-   마이크로소프트 에지

-   파일 탐색기

-   Visual Studio Code

#### 랩 파일 다운로드

1.  작업 표시줄에서 **Windows PowerShell** 아이콘을 선택합니다.

1.  PowerShell 명령 프롬프트에서 현재 작업 디렉터리를 **Allfiles(F):\\** 경로로 변경합니다.

```
    cd F:
```

1.  명령 프롬프트 내에서 다음 명령을 입력하고 Enter 키를 눌러 GitHub에서 호스트되는 **microsoftlearning/AZ-203-DevelopingSolutionsforMicrosoftAzure** 프로젝트를 **Allfiles (F):\\** 드라이브로 복제합니다.

```
    git clone --depth 1 --no-checkout https://github.com/microsoftlearning/AZ-203-DevelopingSolutionsForMicrosoftAzure.
```

1.  명령 프롬프트 내에서 다음 명령을 입력하고 **Enter** 키를 눌러 **AZ-203T03** 랩을 완료하는 데 필요한 랩 파일을 체크 아웃합니다.

```
    git checkout master -- Allfiles/*
```

1.  현재 실행 중인 **Windows PowerShell** 명령 프롬프트 응용 프로그램을 닫습니다.

### 연습 1: Azure에서 데이터베이스 리소스 만들기

#### 작업 1: Azure Portal 열기

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 **Azure Portal**([portal.azure.com](https://portal.azure.com))로 이동합니다.

1.  Microsoft 계정의 **전자 메일 주소**를 입력합니다.

1.  **다음**을 선택합니다.

1.  Microsoft 계정의 **비밀번호**를 입력합니다.

1.  **로그인**을 선택합니다.

    > **참고**: **Azure Portal**에 처음 로그인하는 경우 포털 둘러보기를 제공하는 대화 상자가 나타납니다. 둘러보기를 건너뛰고 포털 사용을 시작하려면 **시작하기**를 선택합니다.

#### 작업 2: Azure Cache for Redis 리소스 만들기

1.  Azure Portal의 왼쪽에 있는 탐색 창에서 **모든 서비스**를 선택합니다.

1.  **모든 서비스** 블레이드에서 **Azure Cache for Redis**를 선택합니다.

1.  **Azure Cache for Redis** 블레이드에서 Redis Cache 인스턴스 목록을 봅니다.

1.  **Azure Cache for Redis** 블레이드 상단에서 **+ 추가**를 선택합니다.

1.  **새 Redis Cache** 블레이드에서 다음 작업을 수행합니다.

    1.  **DNS 이름** 필드에 **polyrediscache\[소문자로 된 사용자 이름\]** 값을 입력합니다. 

    1.  **구독** 드롭다운 목록을 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 섹션에서 **새 만들기** 를 선택하고 **수개 국어 데이터**를 입력한 다음 **확인**을 선택합니다.
    
    1.  **위치** 드롭다운 목록에서 **미국 동부** 옵션을 선택합니다.

    1.  **가격 책정 계층** 목록에서 **기본 C0(250MB 캐시)** 옵션을 선택합니다.

    1.  **포트 6379 차단 해제(SSL 암호화되지 않음)** 섹션에서 확인란을 선택 취소합니다.
    
    1. **만들기**를 선택합니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

    > **참고**: Azure Cache for Redis 리소스를 사용할 준비가 되기까지 **15~30분** 정도 걸릴 수 있습니다. 이 랩을 계속 진행하도록 선택할 수도 있지만 이 리소스와 연결 문자열은 **연습 6: Azure Redis Cache에 연결하는 .NET 코드 작성**에 필요합니다.

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서, 이 랩의 앞에서 만든 **polyrediscache\*** Azure Cache for Redis 인스턴스를 선택합니다.

1.  **Azure Cache for Redis** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **액세스 키** 링크를 선택합니다.

1.  **액세스 키** 창에서 **기본 연결 문자열(StackExchange.Redis)** 필드에 값을 기록합니다. 이 랩에서 나중에 이 값을 사용합니다.

#### 작업 3: Azure SQL Server 리소스 만들기

1.  Azure Portal의 왼쪽에 있는 탐색 창에서 **모든 서비스**를 선택합니다.

1.  **모든 서비스** 블레이드에서 **SQL Server**를 선택합니다.

1.  **SQL 서버** 블레이드에서 SQL 서버 인스턴스 목록을 봅니다.

1.  **SQL Server** 블레이드 상단에서 **+ 추가**를 선택합니다.

1.  **SQL Database 서버 만들기** 블레이드에서 **기본**, **네트워킹** 및 **추가 설정**과 같은 블레이드 상단의 탭을 살펴봅니다.

    > **참고**: 각 탭은 새 **Azure SQL Database 서버**를 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기**를 선택하여 나머지 탭을 건너뛸 수 있습니다.

1.  **기본**탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 드롭다운 목록을 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터**를 선택합니다.
    
    1.  **서버 이름** 필드에 **polysqlsrvr\[소문자로 된 사용자 이름]** 값을 입력합니다.
    
    1.  **위치** 드롭다운 목록에서 **(미국) 미국 동부** 옵션을 선택합니다.
    
    1.  **서버 관리자 로그인** 필드에 **testuser** 값을 입력합니다.
    
    1.  **비밀번호** 필드에 비밀번호를 **입력합니다**.
    
    1.  **비밀번호 확인** 필드에 **TestPa$$w0rd** 값을 다시 입력합니다.

    1.  **다음: 네트워킹 >**을 선택합니다.

1.  **네트워킹** 탭에서 다음 작업을 수행합니다.

    1. **Azure 서비스 및 리소스가 이 서버에 액세스할 수 있도록 허용** 섹션에서 **예**를 선택합니다.
    
    1.  **검토 + 만들기**를 선택합니다.

1.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

1.  **만들기**를 선택하여 지정한 구성으로 Azure SQL Database 서버를 만듭니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

#### 작업 4: Azure 코스모스 DB 계정 리소스 만들기

1.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스**를 선택합니다.

1.  **모든 서비스** 블레이드에서 **Azure 코스모스 DB**를 선택합니다.

1.  **Azure 코스모스 DB** 블레이드에서 Azure 코스모스 DB 인스턴스 목록을 봅니다.

1.  **Azure Cosmos DB** 블레이드 상단에서 **+ 추가**를 선택합니다.

1.  **Azure Cosmos DB 계정 만들기** 블레이드에서 **기본**, **네트워크** 및 **태그**와 같은 블레이드 상단의 탭을 살펴봅니다.

    > **참고**: 각 탭은 새 **Azure Cosmos DB 계정**을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기**를 선택하여 나머지 탭을 건너뛸 수 있습니다.

1.  **기본** 탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 목록을 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터**를 선택합니다.
    
    1.  **계정 이름** 필드에 **polycosmos\[소문자로 된 사용자 이름\]**를 입력합니다.
    
    1.  **API** 드롭다운 목록에서 **코어(SQL)** 옵션을 선택합니다.
    
    1.  **위치** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.
    
    1.  **지리적 중복성** 섹션에서 **사용 안 함** 옵션을 선택합니다.
    
    1.  **다중 영역 쓰기** 섹션에서 **사용 안 함** 옵션을 선택합니다.
    
    1.  **검토 + 만들기**를 선택합니다.

1.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

1.  **만들기**를 선택하여 지정한 구성으로 Azure Cosmos DB 계정을 만듭니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서, 이 랩의 앞에서 만든 **polycosmos\*** Azure Cosmos DB 계정을 선택합니다.

1.  **Azure Cosmos DB 계정** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **키** 링크를 선택합니다.

1.  **키** 창에서 **기본 연결 문자열** 필드의 값을 기록합니다. 이 랩에서 나중에 이 값을 사용합니다.

#### 작업 5: Azure 저장소 계정 리소스 만들기

1.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스**를 선택합니다.

1.  **모든 서비스** 블레이드에서 **저장소 계정**을 선택합니다.

1.  **저장소 계정** 블레이드에서 저장소 인스턴스 목록을 봅니다.

1.  **스토리지 계정** 블레이드 상단에서 **+ 추가**를 선택합니다.

1.  **스토리지 계정 만들기** 블레이드에서 **기본**, **고급** 및 **태그**와 같은 블레이드 상단의 탭을 살펴봅니다.

    > **참고**: 각 탭은 새 **Azure Storage 계정**을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기**를 선택하여 나머지 탭을 건너뛸 수 있습니다.

1.  **기본** 탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 목록을 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터**를 선택합니다.
    
    1.  **스토리지 계정 이름** 필드에 **polystor\[소문자로 된 사용자 이름\]**를 입력합니다.
    
    1.  **위치** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.
    
    1.  **성능** 섹션에서 **표준**을 선택합니다.
    
    1.  **계정 종류** 드롭다운 목록에서 **StorageV2(일반용v2)**를 선택합니다.
    
    1.  **복제** 드롭다운 목록에서 **로컬 중복 저장소(LRS)**를 선택합니다.
    
    1.  **액세스 계층(기본값)** 섹션에서 **핫**이 선택되어 있는지 확인합니다.
    
    1.  **검토 + 만들기**를 선택합니다.

1.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

1.  지정된 구성을 사용하여 저장소 계정을 만들려면 **만들기**를 선택합니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

#### 검토

이 연습에서는 수개 국어 데이터 솔루션에 필요한 모든 Azure 리소스를 만들었습니다.

### 연습 2: 데이터베이스 및 이미지 가져오기

#### 작업 1: 이미지 Blob 업로드

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서 이 랩의 앞에서 만든 **polystor\*** 스토리지 계정을 선택합니다.

1.  **스토리지 계정** 블레이드에서 블레이드 왼쪽의 **Blob service** 섹션에 있는 **컨테이너** 링크를 선택합니다.

1.  **컨테이너** 섹션에서 **+ 컨테이너**를 선택합니다.

1.  **새 컨테이너** 팝업에서 다음 작업을 수행합니다.
    
    1.  **이름** 필드에 **images**를 입력합니다.
    
    1.  **공용 액세스 수준** 드롭다운 목록에서 **Blob(Blob에 대한 익명 읽기 전용 액세스)**을 선택합니다.
    
    1.  **확인**을 선택합니다.

1.  **컨테이너** 섹션으로 돌아가서 새로 만든 **이미지** 컨테이너를 선택합니다.

1.  **컨테이너** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **속성** 링크를 선택합니다.

1.  **속성** 창에서 **URL** 필드의 값을 기록합니다. 이 랩에서 나중에 이 값을 사용합니다.

1.  블레이드 왼쪽에 있는 **개요** 링크를 찾아 선택합니다.

1.  블레이드 상단에서 **업로드**를 선택합니다.

1.  **Blob 업로드** 팝업 창에서 다음 작업을 수행합니다.
    
    1.  **파일** 섹션에서 **폴더** 아이콘을 선택합니다.
    
    1.  파일 탐색기 대화 상자에서 **Allfiles (F):\\Allfiles\\Labs\\03\\Starter\\Images**로 이동하여 42개의 **.jpg** 이미지 파일을 모두 선택하고 **열기**를 선택합니다.
    
    1.  **파일이 이미 있는 경우 덮어쓰기**가 선택되어 있는지 확인합니다.
    
    1.  **업로드**를 선택합니다.

1. 이 랩을 계속하기 전에 모든 Blob이 업로드될 때까지 기다립니다.

#### 작업 2: SQL .bacpac 파일 업로드

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서 이 랩의 앞에서 만든 **polystor\*** 스토리지 계정을 선택합니다.

1.  **스토리지 계정** 블레이드에서 블레이드 왼쪽의 **Blob service** 섹션에 있는 **컨테이너** 링크를 선택합니다.

1.  **컨테이너** 섹션에서 **+ 컨테이너**를 선택합니다.

1.  **새 컨테이너** 팝업에서 다음 작업을 수행합니다.
    
    1.  **이름** 필드에 **데이터베이스**를 입력합니다.
    
    1.  **공용 액세스 수준** 드롭다운 목록에서 **비공개(익명 액세스없음)**를 선택합니다.
    
    1.  **확인**을 선택합니다.

1.  **컨테이너** 섹션으로 돌아가서 새로 만든 **데이터베이스** 컨테이너를 선택합니다.

1.  **컨테이너** 블레이드에서 **업로드**를 선택합니다.

1.  **블랍 업로드** 팝업에서 다음 작업을 수행합니다.
    
    1.  **파일** 섹션에서 **폴더** 아이콘을 선택합니다.
    
    1.  파일 탐색기 대화 상자에서 **Allfiles (F):\\Allfiles\\Labs\\03\\Starter**로 이동하여 **AdventureWorks.bacpac** 파일을 선택하고 **열기**를 선택합니다.
    
    1.  **파일이 이미 있는 경우 덮어쓰기**가 선택되어 있는지 확인합니다.
    
    1.  **업로드**를 선택합니다.

1. 이 랩을 계속하기 전에 블랍이 업로드될 때까지 기다립니다.

#### 작업 3: SQL Database 가져오기

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서 이 랩의 앞에서 만든 **polysqlsrvr\*** SQL Server를 선택합니다.

1.  **SQL Server** 블레이드에서 **데이터베이스 가져오기**를 선택합니다.

1.  표시되는 **데이터베이스 가져오기** 블레이드에서 다음 작업을 수행합니다.

    1.  **구독** 목록을 기본값으로 설정합니다.

    1.  **스토리지** 옵션을 선택합니다.

    1.  표시되는 **스토리지 계정** 블레이드에서, 이 랩의 앞에서 만든 **polystor\*** 스토리지 계정을 선택합니다. 

    1.  표시되는 **컨테이너** 블레이드에서 이 랩의 앞에서 만든 **데이터베이스** 컨테이너를 선택합니다. 

    1.  표시되는 **컨테이너** 블레이드에서, 이 랩의 앞에서 만든 **AdventureWorks.bacpac** blob을 선택한 다음 **선택**을 선택하여 블레이드를 닫습니다.

    1.  **데이터베이스 가져오기** 블레이드로 돌아가서 **가격 책정 계층** 옵션을 기본값으로 설정합니다.

    1.  **데이터베이스 이름** 필드에 **AdventureWorks**를 입력합니다.

    1.  **데이터 정렬** 필드를 기본값으로 설정합니다.

    1.  **서버 관리자 로그인** 필드에 **testuser** 값을 입력합니다.
    
    1.  **비밀번호** 필드에 비밀번호를 **입력합니다**.
    
    1.  **확인**을 선택합니다.

1. 이 랩을 계속하기 전에 데이터베이스가 만들어질 때까지 기다립니다.

#### 작업 4: 가져온 SQL Database 사용

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서 이 랩의 앞에서 만든 **polysqlsrvr\*** SQL Server를 선택합니다.

1.  **SQL Server** 블레이드에서 블레이드 왼쪽에 있는 **보안** 섹션을 찾아 **방화벽 및 가상 네트워크** 링크를 선택합니다.

1.  **방화벽 및 가상 네트워크** 창에서 **클라이언트 IP 추가**를 선택한 다음 **저장**을 선택합니다.

    > **참고**: 이 단계를 통해 로컬 컴퓨터가 이 서버와 연결된 데이터베이스에 액세스할 수 있습니다.

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서 이 랩의 앞에서 만든 **AdventureWorks** SQL Database를 선택합니다.

1.  **SQL Database** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **연결 문자열** 링크를 선택합니다.

1.  **연결 문자열** 창에서 **ADO.NET(SQL 인증)** 필드의 값을 기록합니다. 이 랩에서 나중에 이 값을 사용합니다.

1.  다음 작업을 수행하여 기록한 연결 문자열을 업데이트합니다.

    1.  연결 문자열 내에서 ``{your_username}`` 자리 표시자를 찾아 ``testuser``로 바꿉니다.

    1.  연결 문자열 내에서 ``{your_password}`` 자리 표시자를 찾아 ``TestPa$$w0rd``로 바꿉니다.

        > **참고**: 예를 들어 연결 문자열이 원래 ``Server=tcp:polysqlsrvrinstructor.database.windows.net,1433;Initial Catalog=AdventureWorks;User ID={your_username};Password={your_password};``였다면 업데이트된 연결 문자열은 ``Server=tcp:polysqlsrvrinstructor.database.windows.net,1433;Initial Catalog=AdventureWorks;User ID=testuser;Password=TestPa$$w0rd;``가 됩니다.

1.  블레이드 왼쪽에 있는 **쿼리 편집기** 링크를 찾아 선택합니다.

1.  **쿼리 편집기** 창에서 다음 작업을 수행합니다.

    1.  **로그인** 필드에 **testuser** 값을 입력합니다.

    1.  **암호** 필드에 **TestPa$$w0rd** 값을 입력합니다.

    1.  **확인**을 선택합니다.

1.  열린 쿼리 편집기에서 다음 쿼리를 입력합니다.

```
    SELECT * FROM AdventureWorks.dbo.Models
```

1.  **실행**을 선택하여 쿼리를 실행합니다.

1.  쿼리의 결과를 확인합니다.

    > **참고**: 이 쿼리는 웹 애플리케이션의 홈페이지에 표시 되는 모델의 목록을 반환합니다.

1.  쿼리 편집기에서 기존 쿼리를 다음 쿼리로 바꿉니다.

```
    SELECT * FROM AdventureWorks.dbo.Products
```

1.  **실행**을 선택하여 쿼리를 실행합니다.

1.  쿼리의 결과를 확인합니다.

    > **참고**: 이 쿼리는 각 모델과 연결된 제품 목록을 반환합니다.

#### 복습

이 연습에서는 웹 애플리케이션에 사용할 모든 리소스를 가져왔습니다.

### 연습 3: .NET Core 웹 애플리케이션 열기 및 구성

#### 작업 1: 웹 애플리케이션 열기 및 빌드

1.  **시작** 화면에서 **Visual Studio Code** 타일을 선택합니다.

1.  **파일 메뉴에서** **폴더 열기**를 선택합니다.

1.  열리는 파일 탐색기 창에서 **Allfiles (F):\\Allfiles\\03\\Starter\\AdventureWorks**로 이동하고 **폴더 선택**을 선택합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

    > **참고**: ``dotnet 빌드`` 명령은 폴더의 모든 프로젝트를 빌드하기 전에 누락된 NuGet 패키지를 자동으로 복원합니다.

1.  터미널에 출력된 빌드의 결과를 확인합니다. 오류나 경고 메시지 없이 빌드가 성공적으로 완료되어야 합니다.

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 2: SQL 연결 문자열 업데이트

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Web** 프로젝트를 펼칩니다.

1.  **appsettings.json** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  JSON 개체의 3줄에서 **ConnectionStrings.AdventureWorksSqlContext** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

```
    "ConnectionStrings": {
        "AdventureWorksSqlContext": "",
        ...
    },
```

1.  이 랩의 앞에서 기록한 **SQL Database**의 **ADO.NET(SQL 인증) 연결 문자열**에 해당 값을 설정하여 **AdventureWorksSqlContext** 속성의 값을 업데이트합니다.

    > **참고**: 여기에서 업데이트된 연결 문자열을 사용하는 것이 중요합니다. 포털에서 복사된 원래 연결 문자열에는 SQL Database에 연결하는 데 필요한 사용자 이름과 암호가 없습니다.

1.  **Appsettings.json** 파일을 저장합니다.

#### 작업 3: Blob 기본 URL 업데이트

1.  JSON 개체의 줄 8에서 **Settings.BlobContainerUrl** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

```
    "Settings": {
        "BlobContainerUrl": "",
        ...
    }
```

1.  이 랩의 앞에서 기록한 **이미지**라는 **Azure Storage** Blob 컨테이너의 **URL** 속성에 해당 값을 설정하여 **BlobContainerUrl** 속성의 값을 업데이트합니다.

1.  **Appsettings.json** 파일을 저장합니다.

#### 작업 4: 웹 애플리케이션 유효성 검사

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Web** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Web\
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 실행합니다.

```
    dotnet run
```

    > **참고**: ``dotnet run`` 명령은 프로젝트에 대한 변경 내용을 자동으로 빌드한 다음 디버거를 연결하지 않고 웹 애플리케이션을 시작합니다. 이 명령은 실행 중인 애플리케이션의 URL과 할당된 포트를 출력합니다.

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 현재 실행 중인 웹 애플리케이션(<http://localhost:5000>)으로 이동합니다.

1.  웹 애플리케이션에서 첫 페이지에 표시된 모델 목록을 확인합니다.

1.  **Water Bottle** 모델을 찾아 **세부 정보 보기**를 선택합니다.

1.  **Water Bottle** 제품 세부 정보 페이지에서 **카트에 추가**를 선택합니다.

1.  체크 아웃 기능을 현재 사용하지 않도록 설정했는지 확인합니다.

    > **참고**: 지금은 제품 페이지 기능만 구현되어 있습니다. 이 랩에서 나중에 체크 아웃 논리를 구현합니다.

1.  웹 애플리케이션을 표시한 브라우저 창을 닫습니다.

1.  **Visual Studio Code** 창으로 돌아갑니다.

1.  **Visual Studio Code** 창에서 **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 복습

이 연습에서는 Azure의 리소스에 연결하도록 ASP.NET Core 웹 애플리케이션을 구성했습니다.

### 연습 4: SQL 데이터를 Azure Cosmos DB로 마이그레이션

#### 작업 1: 마이그레이션 프로젝트 만들기

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 **AdventureWorks.Migrate**라는 새 .NET 프로젝트를 같은 이름의 폴더에 만듭니다.

```
    dotnet new console --name AdventureWorks.Migrate --langVersion 7.1
```

    > **참고**: ``dotnet new`` 명령은 새 **console** 프로젝트를 같은 이름의 폴더에 만듭니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 기존 **AdventureWorks.Models** 프로젝트에 대한 참조를 추가합니다.

```
    dotnet add .\AdventureWorks.Migrate\AdventureWorks.Migrate.csproj reference .\AdventureWorks.Models\AdventureWorks.Models.csproj
```

    > **참고**: ``dotnet add reference`` 명령은 **AdventureWorks.Model** 프로젝트에 포함된 모델 클래스에 대한 참조를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 기존 **AdventureWorks.Context** 프로젝트에 대한 참조를 추가합니다.

```
    dotnet add .\AdventureWorks.Migrate\AdventureWorks.Migrate.csproj reference .\AdventureWorks.Context\AdventureWorks.Context.csproj
```

    > **참고**: ``dotnet add reference`` 명령은 **AdventureWorks.Context** 프로젝트에 포함된 컨텍스트 클래스에 대한 참조를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Migrate** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Migrate
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 **Microsoft.EntityFrameworkCore.SqlServer**의 버전 **2.2.6**을 가져옵니다.

```
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 2.2.6
```

    > **참고**: ``dotnet add package`` 명령은 **NuGet**에서 **[Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/2.2.6)** 패키지를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 **Microsoft.Azure.Cosmos**의 버전 **3.0.0**을 가져옵니다.

```
    dotnet add package Microsoft.Azure.Cosmos --version 3.0.0
```

    > **참고**: ``dotnet add package`` 명령은 **NuGet**에서 **[Microsoft.Azure.Cosmos](https://www.nuget.org/packages/Microsoft.Azure.Cosmos/3.0.0)** 패키지를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 2: .NET 클래스 만들기 

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Migrate** 프로젝트를 펼칩니다.

1.  **Program.cs** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  **Program.cs** 파일의 코드 편집기 탭에서 기존 파일의 모든 코드를 삭제합니다.

1.  다음 코드 줄을 추가하여 참조된 **AdventureWorks.Models** 및 **AdventureWorks.Context** 프로젝트의 **AdventureWorks.Models** 및 **AdventureWorks.Context** 네임스페이스를 가져옵니다.

```
    using AdventureWorks.Context;
    using AdventureWorks.Models;
```

1.  다음 코드 줄을 추가하여 NuGet에서 가져온 **Microsoft.Azure.Cosmos** 패키지에서 **Microsoft.Azure.Cosmos** 네임스페이스를 가져옵니다.

```
    using Microsoft.Azure.Cosmos;
```

1.  다음 코드 줄을 추가하여 NuGet에서 가져온 **Microsoft.EntityFrameworkCore.SqlServer** 패키지에서 **Microsoft.EntityFrameworkCore** 네임스페이스를 가져옵니다.

```
    using Microsoft.EntityFrameworkCore;
```

1.  다음 코드 줄을 추가하여 이 파일에 사용할 기본 제공 네임스페이스에 대한 **using** 지시문을 추가합니다.

```
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
```

1.  다음 코드를 입력하여 새 **Program** 클래스를 만듭니다.

```
    public class Program
    {
    }
```

1.  **Program** 클래스 내에서 다음 코드 줄을 입력하여 **sqlDBConnectionString**이라는 새 문자열 상수를 만듭니다.

```
    private const string sqlDBConnectionString = "";
```

1.  이 랩의 앞에서 기록한 **SQL Database**의 **ADO.NET(SQL 인증) 연결 문자열**에 해당 값을 설정하여 **sqlDBConnectionString** 문자열 상수를 업데이트합니다.

    > **참고**: 여기에서 업데이트된 연결 문자열을 사용하는 것이 중요합니다. 포털에서 복사된 원래 연결 문자열에는 SQL Database에 연결하는 데 필요한 사용자 이름과 암호가 없습니다.

1.  **Program** 클래스 내에서 다음 코드 줄을 입력하여 **cosmosDBConnectionString**이라는 새 문자열 상수를 만듭니다. 

```
    private const string cosmosDBConnectionString = "";
```

1.  이 랩의 앞에서 기록한 **Azure Cosmos DB 계정**의 **기본 연결 문자열**로 값을 설정하여 **cosmosDBConnectionString** 문자열 상수를 업데이트합니다.

1.  **Program** 클래스 내에서 다음 코드 줄을 입력하여 새 비동기 **Main** 메서드를 만듭니다.

```
    public static async Task Main(string[] args)
    {
    }
```

1.  **Main** 메서드 내에서 다음 코드 줄을 추가하여 콘솔에 소개 메시지를 출력합니다.

```
    await Console.Out.WriteLineAsync("Start Migration");
```

1.  **Program.cs** 파일을 저장합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Migrate** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Migrate
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 4: Entity Framework를 사용하여 SQL Database 레코드 가져오기

1.  **Program.cs** 파일 내 **Program** 클래스의 **Main** 메서드 내에서 다음 코드 줄을 추가하여 **sqlDBConnectionString** 변수를 연결 문자열 값으로 전달하면서 **AdventureWorksSqlContext** 클래스의 새 인스턴스를 만듭니다.

```
    AdventureWorksSqlContext context = new AdventureWorksSqlContext(sqlDBConnectionString);
```

1.  **Main** 메서드 내에서 다음 코드 블록을 추가하여 LINQ 쿼리를 실행함으로써 데이터베이스에서 모든 **Models** 및 하위 **Products**를 가져오고 메모리 내 **List<>** 컬렉션에 저장합니다.

```
    List<Model> items = await context.Models
        .Include(m => m.Products)
        .ToListAsync<Model>();
```

1.  **Main** 메서드 내에서 다음 코드 줄을 추가하여 **Azure SQL Database**에서 가져온 레코드 수를 출력합니다.

```
    await Console.Out.WriteLineAsync($"Total Azure SQL DB Records: {items.Count}");
```

1.  **Program.cs** 파일을 저장합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Migrate** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Migrate
```
    
1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

    > **참고**: 빌드 오류가 있는 경우 **Allfiles (F):\\Allfiles\\Labs\\03\\Solution\\AdventureWorks\\AdventureWorks.Migrate** 폴더에 있는 **Program.cs** 파일을 검토하십시오.

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 5: Azure Cosmos DB에 항목 삽입

1.  **Program.cs** 파일 내 **Program** 클래스의 **Main** 메서드 내에서 다음 코드 줄을 추가하여 **CosmosClient** 변수를 연결 문자열 값으로 전달하면서 **cosmosDBConnectionString** 클래스의 새 인스턴스를 만듭니다.

```
    CosmosClient client = new CosmosClient(cosmosDBConnectionString);
```

1.  **Main** 메서드 내에서 다음 코드 줄을 추가하여 **Retail**이라는 새 **데이터베이스**(Azure Cosmos DB 계정에 아직 없는 경우)를 만듭니다.

```
    Database database = await client.CreateDatabaseIfNotExistsAsync("Retail");
```

1.  **Main** 메서드 내에서 다음 코드 블록을 추가하여 파티션 키 경로가 **/Category**이고 처리량이 **1000 RU**인 **Online**이라는 새 **컨테이너**(Azure Cosmos DB 계정에 아직 없는 경우)를 만듭니다.

```
    Container container = await database.CreateContainerIfNotExistsAsync("Online",
        partitionKeyPath: $"/{nameof(Model.Category)}",
        throughput: 1000
    );
```

1.  **Main** 메서드 내에서 다음 코드 줄을 추가하여 **count**라는 **int** 변수를 만듭니다.

```
    int count = 0;
```

1.  **Main** 메서드 내에서 다음 코드 블록을 추가하여 **항목** 컬렉션의 개체를 반복하는 **foreach** 루프를 만듭니다.

```
    foreach (var item in items)
    {
    }
```

1.  **Main** 메서드에 포함된 **foreach** 루프 내에서 다음 코드 줄을 추가하여 개체를 Azure Cosmos DB 컬렉션에 **upsert**하고 결과를 **document**라는 **ItemResponse<>** 유형의 변수에 저장합니다.

```
    ItemResponse<Model> document = await container.UpsertItemAsync<Model>(item);
```

1.  **Main** 메서드에 포함된 **foreach** 루프 내에서 다음 코드 줄을 추가하여 각 upsert 작업의 **작업 ID**를 추가합니다.

```
    await Console.Out.WriteLineAsync($"Upserted document #{++count:000} [Activity Id: {document.ActivityId}]");
```

1.  다시 **Main** 메서드 내에서(foreach 루프 외부) 다음 코드 줄을 추가하여 **Azure Cosmos DB**로 내보낸 문서 수를 출력합니다.

```
    await Console.Out.WriteLineAsync($"Total Azure Cosmos DB Documents: {count}");
```

1.  **Program.cs** 파일을 저장합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Migrate** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Migrate
```
    
1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

    > **참고**: 빌드 오류가 있는 경우 **Allfiles (F):\\Allfiles\\Labs\\03\\Solution\\AdventureWorks\\AdventureWorks.Migrate** 폴더에 있는 **Program.cs** 파일을 검토하십시오.

#### 작업 6: 마이그레이션

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 실행합니다.

```
    dotnet run
```

    > **참고**: ``dotnet run`` 명령은 콘솔 애플리케이션을 시작합니다.

1.  초기 SQL 레코드 수, 개별 upsert 활동 식별자, 최종 Azure Cosmos DB 문서 수를 비롯하여 화면에 출력되는 다양한 데이터를 확인합니다.

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 7: 마이그레이션 유효성 검사

1.  **Azure Portal**을 표시한 **Microsoft Edge** 브라우저 창으로 돌아갑니다.

1.  포털의 왼쪽에 있는 탐색 메뉴에서 **리소스 그룹** 링크를 선택합니다.

1.  **리소스 그룹** 블레이드에서, 이 랩의 앞에서 만든 **PolyglotData** 리소스 그룹을 찾아 선택합니다.

1.  **PolyglotData** 블레이드에서, 이 랩의 앞에서 만든 **polycosmos\*** Azure Cosmos DB 계정을 선택합니다.

1.  **Azure Cosmos DB 계정** 블레이드에서 블레이드 왼쪽에 있는 **쿼리 탐색기** 링크를 찾아 선택합니다.

1.  **쿼리 탐색기** 창에서 **Retail** 데이터베이스 노드를 펼칩니다.

1.  **Online** 컨테이너 노드를 펼칩니다.

1.  **새 SQL 쿼리**를 선택합니다.

    > **참고**: 이 옵션의 레이블은 숨겨져 있을 수 있습니다. **데이터 탐색기** 창 상단의 아이콘 위로 마우스를 가져가면 레이블을 볼 수 있습니다.

1.  표시되는 쿼리 탭에서 다음 텍스트를 입력합니다.

```
    SELECT * FROM models
```

1.  **쿼리 실행**을 선택합니다.

1.  쿼리에서 반환되는 JSON 모델 목록을 확인합니다.

1.  쿼리 편집기에서 기존 텍스트를 다음 텍스트로 바꿉니다.

```
    SELECT VALUE COUNT(1) FROM models
```

1.  **쿼리 실행**을 선택합니다.

1.  **COUNT** 집계 작업의 결과를 확인합니다.

1.  **Visual Studio Code** 창으로 돌아갑니다.

#### 복습

이 연습에서는 Entity Framework 및 Azure Cosmos DB용 .NET SDK를 사용하여 Azure SQL Database에서 Azure Cosmos DB로 데이터를 마이그레이션했습니다.

### 연습 5: .NET을 사용한 Azure Cosmos DB 액세스

#### 작업 1: Cosmos SDK 및 참조를 사용하여 라이브러리 업데이트

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Context** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Context\
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 **Microsoft.Azure.Cosmos**를 가져옵니다.

```
    dotnet add package Microsoft.Azure.Cosmos --version 3.0.0
```

    > **참고**: ``dotnet add package`` 명령은 **NuGet**에서 **[Microsoft.Azure.Cosmos](https://www.nuget.org/packages/Microsoft.Azure.Cosmos/3.0.0)** 패키지를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 2: Azure Cosmos DB에 연결하는 .NET 코드 작성

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Context** 프로젝트를 펼칩니다.

1.  컨텍스트 메뉴에 액세스하거나 **AdventureWorks.Context** 폴더 노드를 마우스 오른쪽 단추로 클릭한 다음 **새 파일**을 선택합니다.

1.  표시되는 프롬프트에 **AdventureWorksCosmosContext.cs** 값을 입력합니다.

1.  **AdventureWorksCosmosContext.cs** 파일의 코드 편집기 탭에서 다음 코드 줄을 추가하여 참조된 **AdventureWorks.Models** 프로젝트에서 **AdventureWorks.Models** 네임스페이스를 가져옵니다.

```
    using AdventureWorks.Models;
```

1.  다음 코드 줄을 추가하여 NuGet에서 가져온 **Microsoft.Azure.Cosmos** 패키지에서 **Microsoft.Azure.Cosmos** 및 **Microsoft.Azure.Cosmos.Linq** 네임스페이스를 가져옵니다.

```
    using Microsoft.Azure.Cosmos;
    using Microsoft.Azure.Cosmos.Linq;
```

1.  다음 코드 줄을 추가하여 이 파일에 사용할 기본 제공 네임스페이스에 대한 **using** 지시문을 추가합니다.

```
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
```

1.  다음 코드를 입력하여 **AdventureWorks.Context** 네임스페이스 블록을 추가합니다.

```
    namespace AdventureWorks.Context
    {
    }
```

1.  **AdventureWorks.Context** 네임스페이스 내에서 다음 코드를 입력하여 새 **AdventureWorksCosmosContext** 클래스를 만듭니다.

```
    public class AdventureWorksCosmosContext
    {
    }
```

1.  이 클래스가 **IAdventureWorksProductContext**인터페이스를 구현할 것임을 나타내는 사양을 추가하여 **AdventureWorksCosmosContext** 클래스의 선언을 업데이트합니다.

```
    public class AdventureWorksCosmosContext : IAdventureWorksProductContext
    {
    }
```

1.  **AdventureWorksCosmosContext** 클래스 내에서 다음 코드 줄을 입력하여 **_container**라는 새 읽기 전용 **Container** 변수를 만듭니다.

```
    private readonly Container _container;
```

1.  **AdventureWorksCosmosContext** 클래스 내에서 다음 서명을 사용하여 새 생성자를 추가합니다.

```
    public AdventureWorksCosmosContext(string connectionString, string database = "Retail", string container = "Online")
    {
    }
```

1.  생성자 내에서 다음 코드 블록을 추가하여 **CosmosClient** 클래스의 새 인스턴스를 만든 다음 클라이언트에서 **Database** 및 **Container** 인스턴스를 모두 가져옵니다.

```
    _container = new CosmosClient(connectionString)
        .GetDatabase(database)
        .GetContainer(container);
```

1.  **AdventureWorksCosmosContext** 클래스 내에서 다음 서명을 사용하여 새 **FindModelAsync** 메서드를 추가합니다.

```
    public async Task<Model> FindModelAsync(Guid id)
    {
    }
```

1.  **FindModelAsync** 메서드 내에서 다음 코드 블록을 추가하여 LINQ 쿼리를 만들고, 이를 반복기로 변환하고, 결과 집합을 반복한 다음, 결과 집합에서 단일 항목을 반환합니다.

```
    var iterator = _container.GetItemLinqQueryable<Model>()
        .Where(m => m.id == id)
        .ToFeedIterator<Model>();

    List<Model> matches = new List<Model>();
    while (iterator.HasMoreResults)
    {
        var next = await iterator.ReadNextAsync();
        matches.AddRange(next);
    }

    return matches.SingleOrDefault();
```

1.  **AdventureWorksCosmosContext** 클래스 내에서 다음 서명을 사용하여 새 **GetModelsAsync** 메서드를 추가합니다.

```
    public async Task<List<Model>> GetModelsAsync()
    {
    }
```

1.  **GetModelsAsync** 메서드 내에서 다음 코드 블록을 추가하여 SQL 쿼리를 실행하고, 쿼리 결과 반복기를 가져오고, 결과 집합을 반복한 다음, 모든 결과의 공용 구조체를 반환합니다.

```
    string query = $@"SELECT * FROM items";

    var iterator = _container.GetItemQueryIterator<Model>(query);

    List<Model> matches = new List<Model>();
    while (iterator.HasMoreResults)
    {
        var next = await iterator.ReadNextAsync();
        matches.AddRange(next);
    }

    return matches;
```

1.  **AdventureWorksCosmosContext** 클래스 내에서 다음 서명을 사용하여 새 **FindProductAsync** 메서드를 추가합니다.

```
    public async Task<Product> FindProductAsync(Guid id)
    {
    }
```

1.  **FindProductAsync** 메서드 내에서 다음 코드 블록을 추가하여 SQL 쿼리를 실행하고, 쿼리 결과 반복기를 가져오고, 결과 집합을 반복한 다음, 결과 집합에서 단일 항목을 반환합니다.

```
    string query = $@"SELECT VALUE products
                        FROM models
                        JOIN products in models.Products
                        WHERE products.id = '{id}'";

    var iterator = _container.GetItemQueryIterator<Product>(query);

    List<Product> matches = new List<Product>();
    while (iterator.HasMoreResults)
    {
        var next = await iterator.ReadNextAsync();
        matches.AddRange(next);
    }

    return matches.SingleOrDefault();
```

1.  **AdventureWorksCosmosContext.cs** 파일을 저장합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Context** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Context
```
    
1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

    > **참고**: 빌드 오류가 있는 경우 **Allfiles (F):\\Allfiles\\Labs\\03\\Solution\\AdventureWorks\\AdventureWorks.Context** 폴더에 있는 **AdventureWorksCosmosContext.cs** 파일을 검토하십시오.

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 3: Azure Cosmos DB 연결 문자열 업데이트

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Web** 프로젝트를 펼칩니다.

1.  **appsettings.json** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  JSON 개체의 줄 4에서 **ConnectionStrings.AdventureWorksCosmosContext** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

```
    "ConnectionStrings": {
        ...
        "AdventureWorksCosmosContext": "",
        ...
    },
```

1.  이 랩의 앞에서 기록한 **Azure Cosmos DB 계정**의 **기본 연결 문자열**로 값을 설정하여 **AdventureWorksCosmosContext** 속성의 값을 업데이트합니다.

1.  **Appsettings.json** 파일을 저장합니다.

#### 작업 4: .NET 애플리케이션 시작 논리 업데이트

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Web** 프로젝트를 펼칩니다.

1.  **Startup.cs** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  **Startup** 클래스에서 기존 **ConfigureProductService** 메서드를 찾습니다.

```
    public void ConfigureProductService(IServiceCollection services)
    {
        services.AddScoped<IAdventureWorksProductContext, AdventureWorksSqlContext>(provider =>
            new AdventureWorksSqlContext(
                _configuration.GetConnectionString(nameof(AdventureWorksSqlContext))
            )
        );
    }
```

    > **참고**: 현재 제품 서비스는 SQL을 데이터베이스로 사용합니다.

1.  **ConfigureProductService** 메서드 내에서 기존 코드 줄을 모두 삭제합니다.

```
    public void ConfigureProductService(IServiceCollection services)
    {
    }
```

1.  **ConfigureProductService** 메서드 내에서 다음 코드 블록을 추가하여 이 랩의 앞에서 만든 **AdventureWorksCosmosContext** 구현으로 제품 공급자를 변경합니다.

```
    services.AddScoped<IAdventureWorksProductContext, AdventureWorksCosmosContext>(provider =>
        new AdventureWorksCosmosContext(
            _configuration.GetConnectionString(nameof(AdventureWorksCosmosContext))
        )
    );
```

1.  **Startup.cs** 파일을 저장합니다.

#### 작업 5: Azure Cosmos DB에 연결된 .NET 애플리케이션 유효성 검사

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Web** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Web\
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 실행합니다.

```
    dotnet run
```

    > **참고**: ``dotnet run`` 명령은 프로젝트에 대한 변경 내용을 자동으로 빌드한 다음 디버거를 연결하지 않고 웹 애플리케이션을 시작합니다. 이 명령은 실행 중인 애플리케이션의 URL과 할당된 포트를 출력합니다.

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 현재 실행 중인 웹 애플리케이션(<http://localhost:5000>)으로 이동합니다.

1.  웹 애플리케이션에서 첫 페이지에 표시된 모델 목록을 확인합니다.

1.  **Touring-1000** 모델을 찾아 **세부 정보 보기**를 선택합니다.

1.  **Touring-1000** 제품 세부 정보 페이지에서 다음 작업을 수행합니다.

    1.  **옵션 선택** 목록에서 **Touring-1000 Yellow, 50, $2,384.07**을 선택합니다.
    
    1.  **카트에 추가**를 선택합니다.

1.  체크 아웃 기능을 여전히 사용하지 않도록 설정했는지 확인합니다.

    > **참고**: 다음 연습에서는 체크 아웃 논리를 구현합니다.

1.  웹 애플리케이션을 표시한 브라우저 창을 닫습니다.

1.  **Visual Studio Code** 창으로 돌아갑니다.

1.  **Visual Studio Code** 창에서 **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 복습

이 연습에서는 .NET SDK를 사용하여 Azure Cosmos DB 컬렉션을 쿼리하는 C# 코드를 작성했습니다.

### 연습 6: .NET을 사용하여 Azure Cache for Redis 액세스

#### 작업 1: StackExchange.Redis SDK 및 참조를 사용하여 라이브러리 업데이트

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Context** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Context\
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 **Newtonsoft.Json**을 가져옵니다.

```
    dotnet add package Newtonsoft.Json --version 12.0.2
```

    > **참고**: ``dotnet add package`` 명령은 **NuGet**에서 **[Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/12.0.2)** 패키지를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 **StackExchange.Redis**를 가져옵니다.

```
    dotnet add package StackExchange.Redis --version 2.0.601
```

    > **참고**: ``dotnet add package`` 명령은 **NuGet**에서 **[StackExchange.Redis](https://www.nuget.org/packages/StackExchange.Redis/2.0.601)** 패키지를 추가합니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 2: Azure Cache for Redis에 연결하는 .NET 코드 작성

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Context** 프로젝트를 펼칩니다.

1.  컨텍스트 메뉴에 액세스하거나 **AdventureWorks.Context** 폴더 노드를 마우스 오른쪽 단추로 클릭한 다음 **새 파일**을 선택합니다.

1.  표시되는 프롬프트에 **AdventureWorksRedisContext.cs** 값을 입력합니다.

1.  **AdventureWorksRedisContext.cs** 파일의 코드 편집기 탭에서 다음 코드 줄을 추가하여 참조된 **AdventureWorks.Models** 프로젝트에서 **AdventureWorks.Models** 네임스페이스를 가져옵니다.

```
    using AdventureWorks.Models;
```

1.  다음 코드 줄을 추가하여 NuGet에서 가져온 **Newtonsoft.Json** 패키지에서 **Newtonsoft.Json** 네임스페이스를 가져옵니다.

```
    using Newtonsoft.Json;
```

1.  다음 코드 줄을 추가하여 NuGet에서 가져온 **StackExchange.Redis** 패키지에서 **StackExchange.Redis** 네임스페이스를 가져옵니다.

```
    using StackExchange.Redis;
```

1.  다음 코드 줄을 추가하여 이 파일에 사용할 기본 제공 네임스페이스에 대한 **using** 지시문을 추가합니다.

```
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
```

1.  다음 코드를 입력하여 **AdventureWorks.Context** 네임스페이스 블록을 추가합니다.

```
    namespace AdventureWorks.Context
    {
    }
```

1.  **AdventureWorks.Context** 네임스페이스 내에서 다음 코드를 입력하여 새 **AdventureWorksRedisContext** 클래스를 만듭니다.

```
    public class AdventureWorksRedisContext
    {
    }
```

1.  이 클래스가 **IAdventureWorksCheckoutContext**인터페이스를 구현할 것임을 나타내는 사양을 추가하여 **AdventureWorksRedisContext** 클래스의 선언을 업데이트합니다.

```
    public class AdventureWorksRedisContext : IAdventureWorksCheckoutContext
    {
    }
```

1.  **AdventureWorksRedisContext** 클래스 내에서 다음 코드 줄을 입력하여 **_database**라는 새 읽기 전용 **IDatabase** 변수를 만듭니다.

```
    private readonly IDatabase _database;
```

1.  **AdventureWorksRedisContext** 클래스 내에서 다음 서명을 사용하여 새 생성자를 추가합니다.

```
    public AdventureWorksRedisContext(string connectionString)
    {        
    }
```

1.  생성자 내에서 다음 코드 블록을 추가하여 **ConnectionMultiplexer** 클래스의 새 인스턴스를 만든 다음 데이터베이스 인스턴스를 가져옵니다.

```
    ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(connectionString);
    _database = connection.GetDatabase();
```

1.  **AdventureWorksRedisContext** 클래스 내에서 다음 서명을 사용하여 새 **AddProductToCartAsync** 메서드를 추가합니다.

```
    public async Task AddProductToCartAsync(string uniqueIdentifier, Product product)
    {        
    }
```

1.  **AddProductToCartAsync** 메서드 내에서 다음 코드를 추가하여 특정 키의 현재 값을 가져오고, 아직 없는 경우 새 목록을 만들고, 목록에 제품을 추가한 다음, 해당 키의 새 값으로 목록을 데이터베이스에 저장합니다.
    
```
    RedisValue result = await _database.StringGetAsync(uniqueIdentifier);
    List<Product> products = new List<Product>();
    if (!result.IsNullOrEmpty)
    {
        List<Product> parsed = JsonConvert.DeserializeObject<List<Product>>(result.ToString());
        products.AddRange(parsed);
    }
    products.Add(product);
    string json = JsonConvert.SerializeObject(products);
    await _database.StringSetAsync(uniqueIdentifier, json);
```

1.  **AdventureWorksRedisContext** 클래스 내에서 다음 서명을 사용하여 새 **GetProductsInCartAsync** 메서드를 추가합니다.

```
    public async Task<List<Product>> GetProductsInCartAsync(string uniqueIdentifier)
    {        
    }
```

1.  **GetProductsInCartAsync** 메서드 내에서, 다음 코드 줄을 추가하여 데이터베이스에서 목록을 가져오고 JSON 값을 **Product** 인스턴스 컬렉션으로 구문 분석합니다.
    
```    
    string json = await _database.StringGetAsync(uniqueIdentifier);
    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json ?? "[]");
    return products;
```

1.  **AdventureWorksRedisContext** 클래스 내에서 다음 서명을 사용하여 새 **ClearCart** 메서드를 추가합니다.

```
    public async Task ClearCart(string uniqueIdentifier)
    {        
    }
```

1.  **ClearCart** 메서드 내에서, 다음 코드 줄을 추가하여 데이터베이스에서 키와 관련 값을 제거합니다.
    
```
    await _database.KeyDeleteAsync(uniqueIdentifier);
```

1.  **AdventureWorksRedisContext.cs** 파일을 저장합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Context** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Context
```
    
1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

    > **참고**: 빌드 오류가 있는 경우 **Allfiles (F):\\Allfiles\\Labs\\03\\Solution\\AdventureWorks\\AdventureWorks.Context** 폴더에 있는 **AdventureWorksRedisContext.cs** 파일을 검토하십시오.

1.  **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 작업 3: Redis 연결 문자열 업데이트

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Web** 프로젝트를 펼칩니다.

1.  **appsettings.json** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  JSON 개체의 줄 4에서 **ConnectionStrings.AdventureWorksRedisContext** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

```
    "ConnectionStrings": {
        ...
        "AdventureWorksRedisContext": ""
    },
```

1.  이 랩의 앞에서 기록한 **Azure Cache for Redis** 인스턴스의 **기본 연결 문자열(StackExchange.Redis)**로 값을 설정하여 **AdventureWorksRedisContext** 속성의 값을 업데이트합니다.

1.  JSON 개체의 줄 9에서 **Settings.CartAvailable** 경로를 찾습니다. 현재 값이 **false**인 것을 확인합니다.

```
    "Settings": {
        ...
        "CartAvailable": false,
        ...
    }
```

1.  해당 값을 **true**로 설정하여 **CartAvailable** 속성의 값을 업데이트합니다.

```
    "CartAvailable": true,
```

1.  **Appsettings.json** 파일을 저장합니다.

#### 작업 4: .NET 애플리케이션 시작 논리 업데이트

1.  Visual Studio Code 창의 **탐색기** 창에서 **AdventureWorks.Web** 프로젝트를 펼칩니다.

1.  **Startup.cs** 파일을 두 번 클릭(또는 두 번 선택)합니다.

1.  **Startup** 클래스에서 기존 **ConfigureCheckoutService** 메서드를 찾습니다.

```
    public void ConfigureCheckoutService(IServiceCollection services)
    {
        services.AddScoped<IAdventureWorksCheckoutContext>(provider =>
            new Mock<IAdventureWorksCheckoutContext>().Object
        );
    }
```

    > **참고**: 현재 체크 아웃 서비스는 모의 개체를 데이터베이스로 사용합니다.

1.  **ConfigureCheckoutService** 메서드 내에서 기존 코드 줄을 모두 삭제합니다.

```
    public void ConfigureCheckoutService(IServiceCollection services)
    {
    }
```

1.  **ConfigureCheckoutService** 메서드 내에서 다음 코드 블록을 추가하여 이 랩의 앞에서 만든 **AdventureWorksRedisContext** 구현으로 제품 공급자를 변경합니다.

```
    services.AddScoped<IAdventureWorksCheckoutContext, AdventureWorksRedisContext>(provider =>
        new AdventureWorksRedisContext(
            _configuration.GetConnectionString(nameof(AdventureWorksRedisContext))
        )
    );
```

1.  **Startup.cs** 파일을 저장합니다.

#### 작업 5: Azure Cache for Redis에 연결된 .NET 애플리케이션 유효성 검사

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 터미널 컨텍스트를 **AdventureWorks.Web** 폴더로 전환합니다.

```
    cd .\AdventureWorks.Web\
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 실행합니다.

```
    dotnet run
```

    > **참고**: ``dotnet run`` 명령은 프로젝트에 대한 변경 내용을 자동으로 빌드한 다음 디버거를 연결하지 않고 웹 애플리케이션을 시작합니다. 이 명령은 실행 중인 애플리케이션의 URL과 할당된 포트를 출력합니다.

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 현재 실행 중인 웹 애플리케이션(<http://localhost:5000>)으로 이동합니다.

1.  웹 애플리케이션에서 첫 페이지에 표시된 모델 목록을 확인합니다.

1.  **Mountain-400-W** 모델을 찾아 **세부 정보 보기**를 선택합니다.

1.  **Mountain-400-W** 제품 세부 정보 페이지에서 다음 작업을 수행합니다.

    1.  **옵션 선택** 목록에서 **Mountain-400-W Silver, 40, $769.49**를 선택합니다.
    
    1.  **카트에 추가**를 선택합니다.

1.  쇼핑 카트 페이지에서 쇼핑 카트의 내용을 확인한 다음 **체크 아웃**을 선택합니다.

1.  체크아웃 페이지에서 최종 영수증을 확인합니다.

1.  페이지 상단의 **쇼핑 카트** 아이콘을 선택합니다.

1.  쇼핑 카트 페이지에서 빈 카트를 확인합니다.

1.  웹 애플리케이션을 표시한 브라우저 창을 닫습니다.

1.  **Visual Studio Code** 창에서 **휴지통** 아이콘을 선택하여 현재 열려 있는 터미널 및 관련 프로세스를 삭제합니다.

#### 복습

이 연습에서는 C# 코드를 사용하여 Azure Cache for Redis 스토리지에서 데이터를 저장하고 검색했습니다.

### 연습 7: 구독 정리 

#### 작업 1: Azure 클라우드 셸 열기

1.  포털 상단에서 **클라우드 셸** 아이콘을 선택하여 새 셸 인스턴스를 엽니다.

    > **참고**: **Cloud Shell** 아이콘은 기호보다 큰 기호 및 밑줄 문자로 표시됩니다.

1.  구독을 사용하여 **Cloud Shell**을 처음 여는 경우 처음 사용 시 **Cloud Shell**을 구성할 수 있는 **Azure Cloud Shell 마법사 시작** 화면이 나타납니다. 마법사에서 다음 작업을 수행합니다.
    
    1.  셸 사용을 시작하도록 새 스토리지 계정을 만들라는 메시지가 대화 상자에 표시됩니다. 기본 설정을 수락하고 **저장소 만들기**를 선택합니다.
    
    1.  랩으로진행하기 전에 **Cloud Shell**이 첫 번째 설치 절차를 완료할 때까지 기다립니다.

    > **참고**: **Cloud Shell**에 대한 구성 옵션이 표시되지 않으면 이 과정의 랩에서 기존 구독을 사용하고 있기 때문일 수 있습니다. 랩은 새 구독을 사용 한다는 가정에서 작성됩니다.

1.  포털 하단의 **Cloud Shell** 명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 구독의 모든 리소스 그룹을 나열합니다.

```
    az group list
```
1.  프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 리소스 그룹을 삭제하는 데 사용할 수 있는 명령 목록을 봅니다.

```
    az group delete --help
```

#### 작업 2: 리소스 그룹 삭제

1.  프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 **PolyglotData** 리소스 그룹을 삭제합니다.

```
    az group delete --name PolyglotData --no-wait --yes
```
    
1.  포털 하단의 **Cloud Shell** 창을 닫습니다.

#### 작업 3: 활성 애플리케이션 닫기

1.  현재 실행 중인 **Microsoft Edge** 응용 프로그램을 닫습니다.

1.  현재 실행 중인 **Visual Studio Code** 응용 프로그램을 닫습니다.

#### 검토

이 연습에서는 이 랩에 사용된 **리소스 그룹**을 제거하여 구독을 정리했습니다.
