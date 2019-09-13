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

Microsoft 는 커뮤니티에서 필요한 변경 사항을 가져오는 즉시 이 교육 과정을 업데이트합니다. 그러나 클라우드 업데이트가 자주 발생하기 때문에 이 교육 콘텐츠가 업데이트되기 전에 UI가 변경될 수 있습니다. **이 경우 변경 사항에 적응하고 필요에 따라 랩에서 작업합니다.**

## 지침

### 시작하기 전에

#### 랩 가상 기계에 로그인

  - 다음 자격 증명을 사용하여 **Windows 10** 가상 컴퓨터에 로그인합니다.
    
      - **사용자 이름**: 관리자
    
      - **비밀번호**: Pa55w.rd

> > **참고**: 랩 가상 기계 로그인 지침은 교수자가 제공합니다.

#### 설치된 응용 프로그램 검토

  - **Windows 10** 바탕 하단에 있는 작업 표시줄을 관찰합니다. 작업 표시줄에는 이 랩에서 사용할 응용 프로그램에 대한 아이콘이 포함되어 있습니다.
    
      - 마이크로소프트 에지
    
      - 파일 탐색기 
    
      - Visual Studio Code:

#### 랩 파일 다운로드

1.  작업 표시줄에서 **Windows PowerShell** 아이콘을 선택합니다. 

2.  PowerShell 명령 프롬프트에서 현재 작업 디렉토리를 **Allfiles(F):\\** 경로로 변경합니다.

    ```
    cd F:
    ```

3.  명령 프롬프트 내에서 다음 명령을 입력하고  Enter 를 누르며 GitHub 에서 호스팅되는 **microsoftlearning/AZ-203-DevelopingSolutionsForAzure** 프로젝트를 **랩파일** 디렉토리로 복제합니다.

    ```
    git clone --depth 1 --no-checkout https://github.com/microsoftlearning/AZ-203-DevelopingSolutionsForMicrosoftAzure .
    ```

4.  명령 프롬프트 내에서 다음 명령을 입력하고 **Enter** 를 눌러 **AZ-203.02** 랩을 완료할 때 필요한 랩 파일을 체크 아웃합니다.

    ```
    git checkout master -- Allfiles/*
    ```

5.  현재 실행 중인 **Windows PowerShell** 명령 프롬프트 응용 프로그램을 닫습니다.

### 연습 1: Azure에서 데이터베이스 리소스 만들기

#### 작업 1: Azure 포털 열기

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

2.  열린 브라우저 창에서 **Azure portal** 로 이동합니다. ([portal.azure.com](https://portal.azure.com)) 

3.  Microsoft 계정의 **전자 메일 주소** 를 입력합니다.

4.  **다음** 을 선택합니다.

5.  Microsoft 계정의 **비밀번호** 를 입력합니다.

6.  **로그인** 을 선택합니다.

> > 참고: **Azure Portal** 에 처음 로그인하는 경우 포털 둘러보기를 제공하는 대화 박스가 나타납니다. 둘러보기를 건너뛰고 포털 사용을 시작하려면 **시작하기** 를 선택합니다.

#### 작업 2: SQL 데이터베이스 리소스 만들기

1.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

2.  **모든 서비스** 블레이드에서 **SQL 서버** 를 선택합니다.

3.  **SQL 서버** 블레이드에서 SQL 서버 인스턴스 목록을 봅니다.

4.  **SQL 서버** 블레이드 상단에서 **추가** 를 선택합니다.

5.  **SQL 서버(로직 서버만)** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **서버 이름** 필드에 **polysqlsrvr\[소문자로 이름]** 값을 입력합니다.
    
    2.  **서버 관리자 로그인** 필드에 **testuser** 값을 입력합니다.
    
    3.  **비밀번호** 필드에 비밀번호를 **입력합니다**.
    
    4.  **비밀번호 확인** 필드에 **TestPa$$w0rd** 값을 다시 입력합니다.
    
    5.  **구독** 드롭다운 목록을 기본값으로 설정합니다.
    
    6.  **리소스 그룹** 섹션에서 **새 만들기** 를 선택하고 **수개 국어 데이터** 를 입력한 다음 **확인** 을 선택합니다.
    
    7.  **위치** 드롭다운 목록에서 **미국 동부** 옵션을 선택합니다.
    
    8.  **Azure 서비스 서버 액세스 허용** 섹션에서 확인란이 선택되어 있는지 확인합니다.
    
    9.  **고급 데이터 보안** 섹션에서 **지금 하지 않음** 옵션을 선택합니다.
    
    10. **만들기** 를 선택합니다.

6.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

7.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

8.  **모든 서비스** 블레이드에서 **SQL 데이터베이스** 를 선택합니다.

9.  **SQL 데이터베이스** 블레이드에서 SQL 데이터베이스 인스턴스 목록을 봅니다.

10. **SQL 데이터베이스** 블레이드 맨 위에 있는 **추가** 를 선택합니다.

11. **SQL 데이터베이스 만들기** 블레이드에서 **기본**, **추가 설정** 및 **태그** 와 같은 블레이드 상단의 탭을 관찰합니다.

> 참고: 각 탭은 새 **Azure SQL 데이터베이스** 를 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기** 를 선택하여 나머지 탭을 건너뛸 수 있습니다.

12. **기본** 탭에서 다음 작업을 수행합니다：
    
    11. **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    12. **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터** 를 선택합니다.
    
    13. **데이터베이스** **이름** 텍스트 박스에 **polysqldb** 를 입력합니다.
    
    14. **서버** 필드에서 **polysqlsrvr\[소문자에서 이름]]** 옵션을 선택합니다.
    
    15. **SQL 탄력 풀을 사용하려고 함** 섹션에서 **아니오** 옵션을 선택합니다.
    
    16. **계산 + 저장소** 옵션을 기본값으로 설정합니다.
    
    17. **검토 + 만들기** 를 선택합니다.

13. **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

14. 지정된 구성을 사용하여 저장소 계정을 만들려면 **만들기** 를 선택합니다.

15. 이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

16. Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

17. **모든 서비스** 블레이드에서 **SQL 데이터베이스** 를 선택합니다.

18. **SQL 데이터베이스** 블레이드에서 **polysqldb** 라는 SQL 데이터베이스 인스턴스를 선택합니다.

19. **SQL 데이터베이스** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **연결 문자열** 링크를 선택합니다.

20. **연결 문자열** 페인에서 **ADO.NET** 연결 문자열의 값을 복사합니다. *{your\_username}* 및 * {your\_password}*의 플레이스 홀더 값을 각각 테스트유저****와 TestPa$$w0rd로 바꿔야 합니다.

> > 참고: 예를 들어 복사된 연결 문자열이

    Server=tcp:polysqlsrvrstudent.database.windows.net,1433;Initial Catalog=polysqldb;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;,

> > 업데이트된 연결 문자열은

    Server=tcp:polysqlsrvrstudent.database.windows.net,1433;Initial Catalog=polysqldb;Persist Security Info=False;User ID=testuser;Password=TestPa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

21. Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

22. **모든 서비스** 블레이드에서 **SQL 서버** 를 선택합니다.

23. **SQL 서버** 블레이드에서 접두사 **polysqlsrvr** 이 있는 SQL 서버 인스턴스를 선택합니다.

24. **SQL 서버** 블레이드에서 블레이드 왼쪽에 있는 **보안** 섹션을 찾아 **방화벽 및 가상 네트워크** 링크를 선택합니다.

25. **방화벽 및 가상 네트워크** 페인에서 **클라이언트 IP 추가** 를 선택하여 가상 기계의 IP 주소를 허용된 IP 주소 범위 목록에 추가합니다.

26. 페이지 위쪽에서 사이트 **저장** 을 선택합니다.

> > 참고: 방화벽이 서버에서 업데이트되는 경우 몇 분 정도 걸릴 수 있습니다.

27. 저장 작업이 완료되면 **확인** 대화 박스를 해제하려면 확인을 선택합니다.

#### 작업 3: Azure 코스모스 DB 계정 리소스 만들기

1.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

2.  **모든 서비스** 블레이드에서 **Azure 코스모스 DB** 를 선택합니다.

3.  **Azure 코스모스 DB** 블레이드에서 Azure 코스모스 DB 인스턴스 목록을 봅니다.

4.  **Azure 코스모스 DB** 블레이드 상단에서 **추가** 를 선택합니다.

5.  **Azure Cosmos DB 계정 만들기** 블레이드에서 **기본**, **네트워크** 및 **태그** 와 같은 블레이드 상단의 탭을 관찰합니다.

> 참고: 각 탭은 새 **Azure Cosmos DB 계정** 을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기** 를 선택하여 나머지 탭을 건너뛸 수 있습니다.

6.  **기본** 탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    2.  **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터** 를 선택합니다.
    
    3.  **계정** **이름** 텍스트 박스에 **polycosmos\[소문자로 이름]** 입력합니다.
    
    4.  **API** 드롭다운 목록에서 **코어(SQL)** 옵션을 선택합니다.
    
    5.  **위치** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.
    
    6.  **지리적 중복성** 섹션에서 **사용 안 함** 옵션을 선택합니다.
    
    7.  **다중 영역 쓰기** 섹션에서 **사용 안 함** 옵션을 선택합니다.
    
    8.  **검토 + 만들기** 를 선택합니다.

7.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

8.  지정된 구성을 사용하여 저장소 계정을 만들려면 **만들기** 를 선택합니다.

9.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

10. Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

11. **모든 서비스** 블레이드에서 **Azure 코스모스 DB** 를 선택합니다.

12. **Azure Cosmos DB** 블레이드에서 접두사 **폴리코스모스** 가 포함된 Azure Cosmos DB 계정 인스턴스를 선택합니다.

13. **Azure Cosmos DB 계정** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **키** 링크를 선택합니다.

14. **키** 페인에서 **URI** 및 **기본 키** 필드의 값을 기록합니다. 이 랩의 나중에 이러한 값을 사용합니다.

#### 작업 4: Azure 저장소 계정 리소스 만들기

1.  Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

2.  **모든 서비스** 블레이드에서 **저장소 계정** 을 선택합니다.

3.  **저장소 계정** 블레이드에서 저장소 인스턴스 목록을 봅니다.

4.  **저장소 계정** 블레이드 상단에서 **추가** 를 선택합니다.

5.  **저장소 계정 만들기** 블레이드에서 **기본**,  **고급** 및 **태그** 와 같은 블레이드 상단의 탭을 관찰합니다.

> 참고: 각 탭은 새 **Azure 저장소 계정** 을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기** 를 선택하여 나머지 탭을 건너뛸 수 있습니다.

6.  **기본** 탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    2.  **리소스 그룹** 섹션의 목록에서 **수개 국어 데이터** 를 선택합니다.
    
    3.  **저장소 계정** **이름** 텍스트 박스에 **polystor\[소문자로 이름]** 을 입력합니다.
    
    4.  **위치** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.
    
    5.  **성능** 섹션에서 **표준** 을 선택합니다.
    
    6.  **계정 종류** 드롭다운 목록에서 **StorageV2(일반용 v2)를 선택합니다***.*
    
    7.  **복제** 드롭다운 목록에서 ** 로컬 중복 저장소(LRS)** 를 선택합니다.
    
    8.  **액세스 계층(기본값)** 섹션에서 **Hot ** 가 선택되어 있는지 확인합니다.
    
    9.  **검토 + 만들기** 를 선택합니다.

7.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

8.  지정된 구성을 사용하여 저장소 계정을 만들려면 **만들기** 를 선택합니다.

9.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

10. Azure 포털의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스** 를 선택합니다.

11. **모든 서비스** 블레이드에서 **저장소 계정** 을 선택합니다.

12. **저장소 계정** 블레이드에서 접두사 **polystor** 가 있는 Azure Storage 계정 인스턴스를 선택합니다.

13. **저장소 계정** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **액세스 키** 링크를 선택합니다.

14. **액세스 키** 블레이드에서 키 중 하나를 선택하고 **연결 문자열** 텍스트 상자에 값을 기록합니다. 이 랩의 나중에 이 값을 사용합니다.

#### 검토

이 연습에서는 수개 국어 데이터 솔루션에 필요한 모든 Azure 리소스를 만들었습니다.

### 연습 2: ASP.NET 코어 웹 응용 프로그램 열기 및 구성

#### 작업 1: 웹 응용 프로그램 열기

1.  **시작** 화면에서 **비주얼 스튜디오 코드** 타일을 선택합니다.

2.  **파일 메뉴에서** **폴더 열기** 를 선택합니다.

3.  열리는 파일 탐색기 페인에서 **Allfiles (F):\\Labfiles\\Starter** 으로 이동하여 **폴더 선택** 을 선택합니다.

#### 작업 2: 응용 프로그램 설정 업데이트

1.  비주얼 스튜디오 코드 창의 **탐색기** 페인에서 **Contoso.Events.Web** 프로젝트를 확장합니다.

2.  **탐색기** 페인에서 **appsettings.json** 을 두 번 클릭합니다.

3.  JSON 오브젝트에서 13줄에서 **onnectionStrings.EventsContextConnectionString** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "ConnectionStrings": {
    "EventsContextConnectionString": ""
    },

4.  이 랩에서 이전에 기록한 **SQL 데이터베이스** 의 **연결 문자열**에 해당 값을 설정하여 **EventsContextConnectionString** 속성의 값을 업데이트합니다.

5.  JSON 오브젝트에서 9 줄에서 **CosmosSettings.EndpointUrl** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "CosmosSettings": {
    "DatabaseId": "EventsDatabase ",
    "CollectionId": "RegistrationCollection",
    "EndpointUrl": "",
    "AuthorizationKey": ""
    },

6.  이전에 랩에서 기록한 **Azure Cosmos DB 계정** 의 **Endpoint Uri** 로 값을 설정하여 **EndpointUrl** 속성의 값을 업데이트합니다.

7.  JSON 오브젝트에서 10줄에서 **CosmosSettings.AuthorizationKey** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "CosmosSettings": {
    "DatabaseId": "EventsDatabase ",
    "CollectionId": "RegistrationCollection",
    "EndpointUrl": "",
    "AuthorizationKey": ""
    },

8.  이전에 랩에서 기록한 **Azure Cosmos DB 계정** 의 **키** 에 해당 값을 설정 하여 **AuthorizationKey** 속성의 값을 업데이트합니다.

9.  **Appsettings.json** 파일을 저장합니다.

10. 비주얼 스튜디오 코드 창의 **탐색기** 페인에서 **Contoso.Events.Worker** 프로젝트를 확장합니다.

11. **탐색기** 페인에서 **local.settings.json** 을 두 번 클릭합니다.

12. JSON 오브젝트에서 4 줄에서 **AzureWebJobsStorage** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "AzureWebJobsStorage": "",	

13. 이전에 랩에서 기록한 **저장소 계정**의 **연결 문자열** 에 값을 설정하여 **AzureWebJobsStorage** 속성의 값을 업데이트합니다.

14. JSON 오브젝트에서 5줄에서 **AzureWebJobsDashboard** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "AzureWebJobsDashboard": "",

15. 이전에 랩에서 기록한 **저장소 계정** 의 **연결 문자열** 에 값을 설정하여 **AzureWebJobsDashboard** 속성의 값을 업데이트합니다.

16. JSON 오브젝트에서  6줄에서 **EventsContextConnectionString** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "EventsContextConnectionString": "",

17. 이전에 랩에서 기록한 **SQL** 데이터베이스의 **연결 문자열** 에 해당 값을 설정하여 **EventsContextConnectionString** 속성의 값을 업데이트합니다.

18. JSON 오브젝트에서 7 줄에서 **CosmosEndpointUrl** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "CosmosEndpointUrl": "",

19. 이전에 랩에서 기록한 **Azure Cosmos DB 계정** 의 **Endpoint Uri** 로 값을 설정하여 **CosmosEndpointUrl** 속성의 값을 업데이트합니다.

20. JSON 오브젝트에서 8줄에서 **CosmosAuthorizationKey** 경로를 찾습니다. 현재 값이 비어 있는지 관찰합니다.

<!-- end list -->

    "CosmosAuthorizationKey": "",

21. 이전에 랩에서 기록한 **Azure Cosmos DB 계정** 의 **키** 에 해당 값을 설정하여 ** CosmosAuthorizationKey** 속성의 값을 업데이트합니다.

22. **Local.settings.json** 파일을 저장합니다.

#### 검토

이 연습에서는 Azure의 리소스에 연결하도록 ASP.NET Core 웹 응용 프로그램을 구성했습니다.

### 연습 3: Azure SQL 데이터베이스에 연결하는 엔터티 프레임워크 코드 작성

#### 작업 1: 데이터베이스 초기화 로직 구성

1.  비주얼 스튜디오 코드 창의 탐색기 페인에서 **Contoso.Events.Data** 프로젝트를 확장합니다.

2.  탐색기 페인에서 **ContextInitializer.cs** 를 두 번 클릭합니다.

3.  **InitializeAsync** 메서드를 찾습니다.

<!-- end list -->

    public async Task InitializeAsync(EventsContext eventsContext)

4.  **InitializeAsync** 메서드 내에서 다음 코드 줄을 추가하여 데이터베이스가 만들어지도록 합니다.

<!-- end list -->

    await eventsContext.Database.EnsureCreatedAsync();

5.  다음 코드 블록을 추가하여 데이터베이스에 이벤트가 없는 경우 **if** 블록 내에서만 코드를 실행하는 블록인 경우 조건부 코드를 만듭니다.

<!-- end list -->

    if (!await eventsContext.Events.AnyAsync())
    {
    }

6.  새로 생성된 **if** 블록 내에서 다음 코드 줄을 추가하여 **Event** 클래스의 새 인스턴스를 만듭니다.

<!-- end list -->

    Event eventItem = new Event();

7.  **If** 블록 내에서 다음 코드 블록을 추가하여 새 **Event** 클래스 인스턴스의 다양한 속성을 설정합니다.

<!-- end list -->

    eventItem.EventKey = "FY17SepGeneralConference";
    eventItem.StartTime = DateTime.Today;
    eventItem.EndTime = DateTime.Today.AddDays(3d);
    eventItem.Title = "FY17 September Technical Conference";
    eventItem.Description = "Sed in euismod mi.";
    eventItem.RegistrationCount = 1;

8.  **If** 블록 내에서 다음 코드 줄을 **DbSet\<Event\>** 형식의 속성을 가진 **Event** 가 새 **Events** 클래스 인스턴스에 추가합니다.

<!-- end list -->

    eventsContext.Events.Add(eventItem);

9.  **if 블록 외부 와 이후의 경우 다음 코드 줄을 추가하여 변경 내용을 데이터베이스 컨텍스트에 저장합니다.

<!-- end list -->

    await eventsContext.SaveChangesAsync();

10. **InitializeAsync** 메서드는 이제 다음과 같이  보입니다.

<!-- end list -->

    public async Task InitializeAsync(EventsContext eventsContext)
    {
    await eventsContext.Database.EnsureCreatedAsync();
    
    if (!await eventsContext.Events.AnyAsync())
    {
    Event eventItem = new Event();
    eventItem.EventKey = "FY17SepGeneralConference";
    eventItem.StartTime = DateTime.Today;
    eventItem.EndTime = DateTime.Today.AddDays(3d);
    eventItem.Title = "FY17 September Technical Conference";
    eventItem.Description = "Sed in euismod mi.";
    eventItem.RegistrationCount = 1;
    eventsContext.Events.Add(eventItem);
    }
    
    await eventsContext.SaveChangesAsync();
    }

11. **ContextInitializer.cs** 파일을 **저장합니다**.

#### 작업 2: 데이터베이스 초기화 업데이트

1.  비주얼 스튜디오 코드 창의 탐색기 페인에서 **Contoso.Events.Data** 프로젝트를 확장합니다.

2.  탐색기 페인에서 **ContextInitializer.cs** 를 두 번 클릭합니다.

3.  **InitializeAsync** 메서드를 찾습니다.

<!-- end list -->

    public async Task InitializeAsync(EventsContext eventsContext)

4.  메서드를 다음 메서드 구현으로 바꿉니다.

<!-- end list -->

    public async Task InitializeAsync(EventsContext eventsContext)
    {
    await eventsContext.Database.EnsureCreatedAsync();
    
    if (!await eventsContext.Events.AnyAsync())
    {
    await eventsContext.Events.AddRangeAsync(
    new List<Event>() 
    {
    new Event { EventKey = "GeneralConferenceAlpha", StartTime = DateTime.Today, EndTime = DateTime.Today.AddDays(5d), Title = "First General Conference", Description = "Sed in euismod mi.", RegistrationCount = 15 },
    new Event { EventKey = "GeneralConferenceBravo", StartTime = DateTime.Today.AddDays(10d), EndTime = DateTime.Today.AddDays(15d), Title = "Second General Conference", Description = "Sed in euismod mi.", RegistrationCount = 20 },
    new Event { EventKey = "GeneralConferenceCharlie", StartTime = DateTime.Today.AddDays(20d), EndTime = DateTime.Today.AddDays(25d), Title = "Third General Conference", Description = "Sed in euismod mi.",  RegistrationCount = 5 },
    new Event { EventKey = "GeneralConferenceDelta", StartTime = DateTime.Today.AddDays(30d), EndTime = DateTime.Today.AddDays(35d), Title = "Fourth General Conference", Description = "Sed in euismod mi.", RegistrationCount = 25 },
    new Event { EventKey = "GeneralConferenceEcho", StartTime = DateTime.Today.AddDays(40d), EndTime = DateTime.Today.AddDays(45d), Title = "Fifth General Conference", Description = "Sed in euismod mi.", RegistrationCount = 10 },
    new Event { EventKey = "GeneralConferenceFoxtrot", StartTime = DateTime.Today.AddDays(50d), EndTime = DateTime.Today.AddDays(55d), Title = "Sixth General Conference", Description = "Sed in euismod mi.", RegistrationCount = 0 }
    }
    );
    
    await eventsContext.SaveChangesAsync();
    }
    }

5.  **ContextInitializer.cs** 파일을 **저장합니다**.

#### 작업 3: ASP.NET MVC 컨트롤러에 엔터티 프레임워크 쿼리 작성

1.  비주얼 스튜디오 코드 창의 탐색기 ** ** 페인에서 **Contoso.Events.Web** 프로젝트를 확장합니다.

2.  탐색기 페인에서 **컨트롤러** 폴더를 확장합니다.

3.  탐색기 ** ** 페인에서 **HomeController.cs** 를 두 번 클릭합니다.

4.  **인덱스** 메서드를 찾습니다.

<!-- end list -->

    public IActionResult Index([FromServices] EventsContext eventsContext, [FromServices] IOptions<ApplicationSettings> appSettings)

5.  **Index** 메서드 내에서 다음 코드 줄을 찾습니다.

<!-- end list -->

    var upcomingEvents = Enumerable.Empty<Event>();

6.  해당 코드 줄을 다음 코드 블록으로 대체하여 **Events** 테이블을 쿼리하고 **StartTime** 속성별로 결과를 정렬한 다음 응용 프로그램설정에 따라 결과의 부분 집합을 검색(테이크)합니다.

<!-- end list -->

    var upcomingEvents = eventsContext.Events
    .Where(e => e.StartTime >= DateTime.Today)
    .OrderBy(e => e.StartTime)
    .Take(appSettings.Value.LatestEventCount);

7.  **HomeController.cs** 파일을 **저장합니다**.

8.  탐색기 ** ** 페인에서 **EventsController.cs** 를 두 번 클릭합니다.

9.  **인덱스** 메서드를 찾습니다.

<!-- end list -->

    public IActionResult Index([FromServices] EventsContext eventsContext, [FromServices] IOptions<ApplicationSettings> appSettings, int? page)

10. **Index** 메서드 내에서 다음 코드 줄을 찾습니다.

<!-- end list -->

    var pagedEvents = Enumerable.Empty<Event>();

11. 해당 코드 줄을 다음 코드 블록으로 바꿔 **Events** 테이블을 쿼리하고 **킵** 및 **테이크** 메서드를 사용하여 현재 페이지 번호를 기반으로 결과 페이지를 만듭니다.

<!-- end list -->

    int currentPage = page ?? 1;
    int totalRows = eventsContext.Events.Count();
    int pageSize = appSettings.Value.GridPageSize;
    var pagedEvents = eventsContext.Events
    .OrderByDescending(e => e.StartTime)
    .Skip(pageSize * (currentPage - 1))
    .Take(pageSize);

12. **Index** 메서드 내에서 다음 코드 블록을 찾습니다.

<!-- end list -->

    EventsGridViewModel viewModel = new EventsGridViewModel
    {
    CurrentPage = 0,
    PageSize = 0,
    TotalRows = 0,
    Events = pagedEvents
    };	

13. 해당 코드 블록을 다음 코드 블록으로 바꿔 **EventsGridViewModel** 클래스 인스턴스의 다양한 속성을 설정합니다.

<!-- end list -->

    EventsGridViewModel viewModel = new EventsGridViewModel
    {
    CurrentPage = currentPage,
    PageSize = pageSize,
    TotalRows = totalRows,
    Events = pagedEvents
    };

14. **세부** 정보 메서드를 찾습니다.

<!-- end list -->

    public IActionResult Detail([FromServices] EventsContext eventsContext, string key)

15. **세부** 메서드 내에서 다음 코드 줄을 찾습니다.

<!-- end list -->

    var matchedEvent = default(Event);

16. 해당 코드 줄을 다음 코드 블록으로 바꿔 **Events** Table에서 **EventKey** 속성과 일치하는 싱글 레코드를 쿼리합니다.

<!-- end list -->

    var matchedEvent = eventsContext.Events
    .SingleOrDefault(e => e.EventKey == key);

17. **EventsController.cs** 파일을 **저장합니다**.

#### 검토

이 연습에서는 엔터티 프레임워크를 사용하여 Azure SQL 데이터베이스에 연결하는 C\# 코드를 작성했습니다.

### 연습 4: Azure 코스모스 DB 에 연결하는 Cosmos DB 클라이언트 라이브러리 코드 작성

#### 작업 1: Azure Functions 프로젝트에서 등록자 이름 검색

1.  비주얼 스튜디오 코드 창의 탐색기 창에서 **Contoso.Events.Worker** 프로젝트를 확장하고 **ProcessDocuments.cs** 파일을 두 번 클릭합니다.

2.  **ProcessDocuments.cs** 파일의 코드 편집기 탭에서 **ProcessDocuments** 클래스를 찾습니다.

<!-- end list -->

    public static class ProcessDocuments

3.  **ProcessDocuments** 클래스 내에서 19줄에 새 코드 줄을 추가하여 **RegistrationContext** 클래스의 새 스태틱 인스턴스를 만듭니다.

<!-- end list -->

    private static RegistrationContext _registrationsContext = _connection.GetCosmosContext();

4.  **프로세스HttpRequestMessage** 메서드를 찾습니다.

<!-- end list -->

    private static async Task<List<string>> ProcessHttpRequestMessage(string eventKey)

5.  **ProcessHttpRequestMessage** 메서드 내에서 40줄에 새 코드 줄을 추가하여 **RegistrationContext** 클래스의 **ConfigureConnectionAsync** 메서드를 사용하여 Azure Cosmos DB에 대한 연결을 구성합니다.

<!-- end list -->

    await _registrationsContext.ConfigureConnectionAsync();

6.  **등록자** 변수에 문자열 값의 빈 컬렉션을 저장하는 41 줄에서 코드 줄을 찾습니다.

<!-- end list -->

    List<string> registrants = new List<string>();

7.  41줄의 코드 줄을 **GetRegistrantsForEvent** **등록 컨텍스트** 클래스의 호출하는 새 코드 줄로 바꿉니다.

<!-- end list -->

    List<string> registrants = await _registrationsContext.GetRegistrantsForEvent(eventKey);

8.  **ProcessDocuments.cs** 파일을 저장합니다.

#### 작업 2: 등록컨텍스트 클래스 구현

1.  비주얼 스튜디오 코드 창의 탐색기** ** 페인에서 **Contoso.Events.Data** 프로젝트를 확장하고 **RegistrationContext.cs 파일** 을 두 번 클릭합니다.

2.  **RegistrationContext.cs** 파일의 코드 편집기 탭에서 **RegisterContext** 클래스를 찾습니다.

<!-- end list -->

    public class RegistrationContext

3.  **RegistrationContext** 클래스 내에서 새 코드 줄을 추가하여 **데이터베이스** 형식의 새 속성을 만듭니다.

<!-- end list -->

    protected Database Database { get; set; }

4.  **RegisterContext** 클래스 내에서 새 코드 줄을 추가하여 **문서컬렉션** 형식의 새 속성을 만듭니다.

<!-- end list -->

    protected DocumentCollection Collection { get; set; }

5.  **RegisterContext** 클래스 내에서 새 코드 줄을 추가하여 **DocumentClient** 형식의 새 속성을 만듭니다.

<!-- end list -->

    protected DocumentClient Client { get; set; }

6.  **RegistrationContext** 클래스 내에서 기존 **RegistrationContext** 생성자  위치를 찾습니다. 

<!-- end list -->

    public RegistrationContext(IOptions<CosmosSettings> cosmosSettings)
    {
    CosmosSettings = cosmosSettings.Value;
    }

7.  생성자 내에서 새 코드 줄을 추가하여 새 **DocumentClient** 인스턴스를 만들고 *Client* 속성에 저장합니다.

<!-- end list -->

    Client = new DocumentClient(new Uri(CosmosSettings.EndpointUrl), CosmosSettings.AuthorizationKey);

8.  **RegisterContext** 클래스 내에서 **ConfigureConnectionAsync** 메서드를 찾아 메서드내의 기존 코드를 삭제합니다.

<!-- end list -->

    public async Task ConfigureConnectionAsync()
    {
    
    }

9.  **ConfigureConnectionAsync** 메서드 내에서 새 코드 줄을 추가하여 새 **데이터베이스** 인스턴스를 만들고 **데이터베이스** 속성에 저장합니다.

<!-- end list -->

    Database = await Client.CreateDatabaseIfNotExistsAsync(new Database { Id = CosmosSettings.DatabaseId });

10. 새 코드 줄을 추가하여 새 **DocumentCollection** 인스턴스를 만들고 **컬렉션** 속성에 저장합니다.

<!-- end list -->

    Collection = await Client.CreateDocumentCollectionIfNotExistsAsync(Database.SelfLink, new DocumentCollection { Id = CosmosSettings.CollectionId });

11. **RegistrationContext** 클래스 내에서 **GetRegistrantCountAsync** 메서드를 찾아 메서드 내의 기존 코드를 삭제합니다.

<!-- end list -->

    public async Task<int> GetRegistrantCountAsync()
    {
    
    }

12. **GetRegistrantCountAsync** 메서드 내에서 새 코드 줄을 추가하여 **EnableCrossPartitionQuery** 속성이 true 값으로 설정된 **FeedOptions** 클래스의 새 인스턴스를 만듭니다.

<!-- end list -->

    FeedOptions options = new FeedOptions { EnableCrossPartitionQuery = true };

13. 새 코드 줄을 추가하여 등록자 수를 얻고 정수 값 컬렉션을 반환하는 쿼리를 만듭니다.

<!-- end list -->

    IDocumentQuery<int> query = Client.CreateDocumentQuery<int>(Collection.SelfLink, "SELECT VALUE COUNT(1) FROM registrants", options).AsDocumentQuery();

14. 코드의 새 블록을 추가하여count라는 정수 변수를 만들고 **IDocumentQuery\<\>** 클래스의 **HasMoreResults** 속성을 반복하고 ***count** **변수의** 최종 값을 반환하는 while 루프를 만듭니다.

<!-- end list -->

    int count = 0;
    while (query.HasMoreResults)
    {
    
    }
    return count;

15. while 루프 내에서 **ExecuteNextAsync\<\>** ** IDocumentQuery\<\>** 클래스의 메서드를 호출하는 코드 줄을 추가하고 그결과를 ***results** * 의 **FeedResponse\&&>>** 로 저장합니다.

<!-- end list -->

    FeedResponse<int> results = await query.ExecuteNextAsync<int>();

16. while 루프 내에서results변수에 저장된 컬렉션에서 **Sum** LINQ 메서드를 호출한 결과로 count변수를 증분하는 코드 줄을 추가합니다.

<!-- end list -->

    count += results.Sum();

17. **RegistrationContext** 클래스 내에서 **GetRegistrantsForEvent** 메서드를 찾아 메서드 내의 기존 코드를 삭제합니다.

<!-- end list -->

    public async Task<List<string>> GetRegistrantsForEvent(string eventKey)
    {
    
    }

18. **GetRegistrantsForEvent** 메서드 내에서 LINQ를 사용하여 ***eventKey** * 매개 변수의 값을 사용하여 특정 이벤트에 대한 등록자를 얻을 하고 **GeneralRegistration** 를 사용하여 해당 등록자를 직렬화 하는 코드 줄을 추가합니다.

<!-- end list -->

    IDocumentQuery<GeneralRegistration> query = Client.CreateDocumentQuery<GeneralRegistration>(Collection.SelfLink).Where(r => r.EventKey == eventKey).AsDocumentQuery();

19. 코드의 새 블록을 추가하여 **List\<\>** 변수를 ***registrants***로 생성하여 **IDocumentQuery\<\>** 클래스의 **HasMoreResults** 속성을 반복하고 ***registrants*** 의 최종 값을 반환하는 while 루프 변수 :

<!-- end list -->

    List<string> registrants = new List<string>();
    while (query.HasMoreResults)
    {
    
    }
    return registrants;

20. while 루프 내에서 **ExecuteNextAsync\<\>** ** IDocumentQuery\<\>** 클래스의 메서드를 호출하는 코드 줄을 추가하고 그결과를 results ** *의 **FeedResponse\<\>** 로 저장합니다.

<!-- end list -->

    FeedResponse<GeneralRegistration> results = await query.ExecuteNextAsync<GeneralRegistration>();

21. 루프 내에서 **GeneralRegistration** 클래스의 두 속성을 싱글 문자열로 프로젝션하고 결과 유형의 **Ienumerable\<\>** 컬렉션을 형식의 resultName ** *라는 변수에 저장하기 위해 LINQ **Select** 메서드를 호출하는 코드 줄을 추가합니다.

<!-- end list -->

    IEnumerable<string> resultNames = results.Select(r => $"{r.FirstName} {r.LastName}");

22. 루프 내에서 다른 코드 줄을 추가하여 **List\<\>** 클래스의 **AddRange** 메서드를 사용하여 **resultNames** 컬렉션의 값으로 **등록자** 컬렉션을 추가합니다.

<!-- end list -->

    registrants.AddRange(resultNames);

23. **RegistrationContext** 클래스 내에서 **UploadEventRegistrationAsync** 메서드를 찾아 메서드 내의 기존 코드를 삭제합니다.

<!-- end list -->

    public async Task<string> UploadEventRegistrationAsync(dynamic registration)
    {
    
    }

24. **UploadEventRegistrationAsync** 메서드 내에서 **DocumentClient** 형식 및 **클라이언트** 속성 및 **CreateDocumentAsync** 메서드를 호출하고 결과를 **ResourceResponse\<Document\>** 형식의 코드 줄을 추가합니다. 이 메서드는 Azure 코스모스 DB에 문서를 업로드합니다.

<!-- end list -->

    ResourceResponse<Document> response = await Client.CreateDocumentAsync(Collection.SelfLink, registration);

25. 도트 표기법을 사용하여 response변수의 **Resource** 속성(문서 **유형**) 과 **문서** 인스턴스의 **Id** 속성에 액세스하는 다른 코드 줄을 추가합니다. 현재 메서드의 결과로 문자열 **Id값을** 값을 반환합니다.

<!-- end list -->

    return response.Resource.Id;

26. **RegistrationContext.cs** 파일을 저장합니다.

#### 검토

이 연습에서는 Azure Cosmos DB에서 문서에 액세스하고 쿼리하는 데 필요한 C\# 코드를 작성했습니다.

### 연습5: Azure 저장소에 연결하는 Azure SDK 코드 작성

#### 작업 1: Azure 함수에 대한 블랍 트리거 및 출력 구현

1.  시각적 스튜디오 코드 창의 탐색기 ** ** 페인에서 **Contoso.Events.Worker** 프로젝트를 확장하고 **ProcessDocuments.cs** 파일을 두 번 클릭합니다.

2.  **ProcessDocuments.cs** 파일의 코드 편집기 탭에서 **ProcessDocuments** 클래스를 찾습니다.

<!-- end list -->

    public static class ProcessDocuments

3.  **ProcessDocuments** 클래스 내에서 **운영** 메서드를 찾습니다.

<!-- end list -->

    public static async Task Run(Stream input, string name, Stream output, TraceWriter log)

4.  *BlobTrigger *매개 변수 특성을 *input *매개 변수에 추가하여 **Run** 메서드의 메서드 서명을 업데이트하여 **signinsheets-pending** 보류 중인 컨테이너의 모든 블랍에 일치하도록 지정합니다.

<!-- end list -->

    public static async Task Run([BlobTrigger("signinsheets-pending/{name}")] Stream input, string name, Stream output, TraceWriter log)

5.  함수를  트리거한 블랍과 이름이 같은 **signinsheets** 컨테이너에 새 블랍을 만들도록 지정하는 출력 *블랍* 매개 변수 특성을 추가하여 **Run** 메서드의 서명을 *앗풋*을 실행합니다:

<!-- end list -->

    public static async Task Run([BlobTrigger("signinsheets-pending/{name}")] Stream input, string name, [Blob("signinsheets/{name}", FileAccess.Write)] Stream output, TraceWriter log)

6.  **Run** 메서드 내에서 23줄에 새 코드 줄을 추가하여 블랍 이름에서 파일 확장명을 제거하여 **이벤트 키** 를 가집니다.

<!-- end list -->

    string eventKey = Path.GetFileNameWithoutExtension(name);

7.  24줄에 새 코드 줄을 추가하여 **ProcessStorageMessage** 메서드 호출에서 **스트림** 결과를 사용하여 **using** 블록을 만듭니다.

<!-- end list -->

    using (MemoryStream stream = await ProcessStorageMessage(eventKey))
    {
    
    }

8.  **Using** 블록 내에서 새 코드 줄을 추가하여 스트림의 **ToArray** 메서드를 호출하여 **byte\[\]** 의 새 변수를 만듭니다.

<!-- end list -->

    byte[] byteArray = stream.ToArray();

9.  **Using** 블록 내에서 다른 코드 줄을 추가하여 *byteArray* 변수와 관련된 다양한 메타데이터에 전달하는 *출력* 변수의 **WriteAsync** 메서드를 호출합니다.

<!-- end list -->

    await output.WriteAsync(byteArray, 0, byteArray.Length);

10. **ProcessDocuments.cs** 파일을 저장합니다.

#### 작업 2: BlobContext 클래스에서 블랍 업로드 구현

1.  비주얼 스튜디오 코드 창의 탐색기 페인에서 **Contoso.Events.Data** 프로젝트를 확장하고 **BlobContext.cs** 파일을 두 번 클릭합니다.

2.  **BlobContext.cs** 파일의 코드 편집기 탭에서 **BlobContext** 클래스를 찾습니다.

<!-- end list -->

    public class BlobContext

3.  **BlobContext** 클래스 내에서 **UploadBlobAsync** 메서드를 찾아 메서드 내의 기존 코드를 삭제합니다.

<!-- end list -->

    public async Task<ICloudBlob> UploadBlobAsync(string blobName, Stream stream)
    {
    
    }

4.  **UploadBlobAsync** 메서드 내에서 새 코드 줄을 추가하여 새 **CloudStorageAccount** 클래스 인스턴스를 만듭니다.

<!-- end list -->

    CloudStorageAccount account = CloudStorageAccount.Parse(StorageSettings.ConnectionString);

5.  **CloudStorageAccount** 클래스의 **CreateCloudBlobClient** 메서드를 사용하여 **CloudBlobClient** 클래스의 새 인스턴스를 만들려면 새 코드 줄을 추가합니다.

<!-- end list -->

    CloudBlobClient blobClient = account.CreateCloudBlobClient();

6.  **CloudBlobClient** 클래스의 **GetContainerReference** 서드를 사용하여 새 컨테이너 또는 기존 컨테이너에 대한 참조를 얻으려면 새 코드 줄을 추가합니다.

<!-- end list -->

    CloudBlobContainer container = blobClient.GetContainerReference($"{StorageSettings.ContainerName}-pending");

7.  새 코드 줄을 추가하여 아직 존재하지 않는 경우 컨테이너를 만드는 **CloudBlobContainer** 클래스의 **CreateIfNotExistsAsync** 메서드를 호출합니다.

<!-- end list -->

    await container.CreateIfNotExistsAsync();

8.  지정된 블랍 이름을 사용하여 새 코드 줄을 추가하여 새 블랍 또는 기존 블랍에 대한 참조를 가집니다.

<!-- end list -->

    ICloudBlob blob = container.GetBlockBlobReference(blobName);

9.  새 코드 줄을 추가하여 ***stream*** 매개 변수를 가져 와서 스트림을 원본으로 되돌리십시오.

<!-- end list -->

    stream.Seek(0, SeekOrigin.Begin);

10. 참조된 블랍에 ***stream*** 매개 변수의 콘텐츠를 업로드하기 위해 새 코드 줄을 추가합니다.

<!-- end list -->

    await blob.UploadFromStreamAsync(stream);

11. 메서드의 결과로 업데이트된 Blob 을 반환 하는 코드의 새 줄을 추가 합니다.

<!-- end list -->

    return new DownloadPayload { Stream = stream, ContentType = blob.Properties.ContentType }; 

12. **BlobContext.cs** 파일을 **저장합니다**.

#### 검토

이 연습에서는 Azure Function 에서 Azure 저장소 Blob 을 조작하기 위해 C\# 코드를 작성했습니다.

### 연습 6: 구독 정리 

#### 작업 1: Azure 클라우드 셸 열기

1.  포털 상단에서 **클라우드 셸** 아이콘을 선택하여 새 셸 인스턴스를 엽니다.

2.  포털 하단의 **클라우드 셸** 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 구독의 모든 리소스 그룹을 나열합니다.

<!-- end list -->

    az group list

3.  프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 리소스 그룹을 삭제할 수 있는 명령 목록을 봅니다.

<!-- end list -->

    az group delete --help

#### 작업 2: 리소스 그룹 삭제

1.  프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 **PolyglotData** 리소스 그룹을 삭제합니다.

<!-- end list -->

    az group delete --name PolyglotData --no-wait --yes

2.  포털 하단의 **클라우드 셸** 페인을 닫습니다.

#### 작업 3: 액티브 응용 프로그램 닫기

1.  현재 실행 중인  **Microsoft Edge** 응용 프로그램을 닫습니다.

2.  현재 실행 중인 **Visual Studio Code** 응용 프로그램을 닫습니다.

#### 검토

이 연습에서는이 랩에 사용된 **리소스 그룹을** 제거하여 구독을 정리했습니다.
