---
lab:
    title: '랩: Azure에 배포된 서비스 모니터링'
    type: '답변 키'
    module: '모듈 5: Azure 솔루션 모니터링, 문제 해결 및 최적화'
---

# 랩: Azure에 배포된 서비스 모니터링
# 학생 랩 답변 키

## Microsoft Azure 사용자 인터페이스

Microsoft 클라우드 도구의 동적 특성을 감안할 때 이 교육 콘텐츠를 개발한 후 Azure 사용자 인터페이스(UI) 변경 사항이 발생할 수 있습니다. 이러한 변경으로 인해 랩 지침 및 단계가 일치하지 않을 수 있습니다.

Microsoft 는 커뮤니티에서 필요한 변경 사항을 가져오는 즉시 이 교육 과정을 업데이트합니다. 그러나 클라우드 업데이트가 자주 이루어지기 때문에 이 교육 콘텐츠가 업데이트되기 전에 UI가 변경될 수 있습니다. **이 경우 변경 사항에 적응하고 필요에 따라 랩에서 작업합니다.**

## 지침

### 시작하기 전에

#### 랩 가상 머신에 로그인

다음 자격 증명을 사용하여 **Windows 10** 가상 머신에 로그인합니다.
    
-   **사용자 이름**: Admin

-   **암호**: Pa55w.rd

> **참고**: 랩 가상 머신 로그인 지침은 강사가 제공합니다.

#### 설치된 응용 프로그램 검토

**Windows 10** 바탕 화면 하단에 있는 작업 표시줄을 살펴봅니다. 작업 표시줄에는 이 랩에서 사용할 응용 프로그램에 대한 아이콘이 포함되어 있습니다.
    
-   Microsoft Edge

-   파일 탐색기

-   Visual Studio Code

-   Windows PowerShell

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

1.  명령 프롬프트 내에서 다음 명령을 입력하고 **Enter** 키를 눌러 **AZ-203T05** 랩을 완료하는 데 필요한 랩 파일을 체크 아웃합니다.

```
    git checkout master -- Allfiles/*
```

1.  현재 실행 중인 **Windows PowerShell** 명령 프롬프트 응용 프로그램을 닫습니다.

### 연습 1: Azure 리소스 만들기 및 구성

#### 작업 1: Azure Portal 열기

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 [**Azure Portal**](https://portal.azure.com)(portal.azure.com)로 이동합니다.

1.  로그인 페이지에서 Microsoft 계정의 **전자 메일 주소**를 입력합니다.

1.  **다음**을 선택합니다.

1.  Microsoft 계정의 **비밀번호**를 입력합니다.

1.  **로그인**을 선택합니다.

> **참고**: **Azure 포털**에 처음 로그인 하는 경우 대화 박스에 포털 둘러보기 제안이 표시됩니다. 둘러보기를 건너뛰고 포털 사용을 시작하려면 **시작하기**를 선택합니다.

#### 작업 2: Application Insights 리소스 만들기

1.  포털의 왼쪽 네비게이션 페인에서 **+ 리소스 만들기**를 선택합니다.

1.  **신규** 블레이드 상단에서 **마켓플레이스 검색** 필드를 찾습니다.

1.  검색 필드에 **인사이트**를 입력하고 Enter 를 누릅니다.

1.  **모든** 검색 결과 블레이드에서 **응용 프로그램 인사이트** 결과를 선택합니다.

1.  **응용 프로그램 인사이트** 블레이드에서 **만들기**를 선택합니다.

1.  두 번째 **Application Insights** 블레이드에서 **기본**과 같은 블레이드의 탭을 살펴봅니다.

    > **참고**: 각 탭은 새 **Application Insights 인스턴스**를 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기**를 선택하여 나머지 탭을 건너뛸 수 있습니다.

1.  **기본**탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 텍스트 상자를 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 섹션에서 **새로 만들기**를 선택하고 **MonitoredAssets**를 입력한 다음 **확인**을 선택합니다.
    
    1.  **이름** 텍스트 상자에 **instrm\[소문자로 된 사용자 이름\]**을 입력합니다.
    
    1.  **위치** 드롭다운 목록에서 **(미국) 미국 동부** 지역을 선택합니다.
    
    1.  **검토 + 만들기**를 선택합니다.

1.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

1.  지정된 구성을 사용하여 Application Insights 인스턴스를 만들려면 **만들기**를 선택합니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

1.  포털의 왼쪽 네비게이션 페인에서 **리소스 그룹**을 선택합니다.

1.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 선택합니다.

1. **모니터링된 자산** 블레이드에서 이전에 랩에서 만든 **instrm\*** 응용 프로그램 인사이트 계정을 선택합니다.

1. **응용 프로그램 인사이트** 블레이드에서 블레이드 왼쪽에 **구성** 범주 내에서 **속성** 링크를 선택합니다.

1. **속성** 섹션에서 **계측 키** 필드의 값을 관찰합니다. 이 키는 클라이언트 응용 프로그램에서 응용 프로그램 인사이트에 연결로 사용합니다.

#### 작업 3: 웹앱 리소스 만들기

1.  포털의 왼쪽 탐색 창에서 **+ 리소스 만들기**를 선택합니다.

1.  **신규** 블레이드 상단에서 **마켓플레이스 검색** 필드를 찾습니다.

1.  검색 필드에 **웹**을 입력하고 Enter 를 누릅니다.

1.  **모든 항목** 검색 결과 블레이드에서 **웹앱** 결과를 선택합니다.

1.  **웹앱** 블레이드에서 **만들기**를 선택합니다.

1.  두 번째 **웹앱** 블레이드에서 **기본**과 같은 블레이드의 탭을 살펴봅니다.

    > **참고**: 각 탭은 새 **웹앱**을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기**를 선택하여 나머지 탭을 건너뛸 수 있습니다.

1.  **기본**탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 텍스트 상자를 기본값으로 설정합니다.
    
    1.  **리소스 그룹** 드롭다운 목록에서 **MonitoredAssets**를 선택합니다.
    
    1.  **이름** 텍스트 상자에 **smpapi\[소문자로 된 사용자 이름\]**을 입력합니다.

    1.  **게시** 섹션에서 **코드**를 선택합니다.

    1.  **런타임 스택** 드롭다운 목록에서 **NET Core 3.0(최신)**을 선택합니다.

    1.  **운영 체제** 섹션에서 **Windows**를 선택합니다.

    1.  **지역** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.

    1.  **Windows 플랜(미국 동부)** 섹션에서 **새로 만들기**를 선택하고 **이름** 텍스트 상자에 **MonitoredPlan**을 입력한 다음 **확인**을 선택합니다.

    1.  **SKU 및 크기** 섹션을 기본값으로 설정합니다.

    1.  **다음: 모니터링**을 선택합니다.

1.  **모니터링** 탭에서 다음 작업을 수행합니다.

    1.  **Application Insights 사용** 섹션에서 **예**를 선택합니다.

    1.  **Application Insights** 드롭다운 목록에서, 이 랩의 앞에서 만든 **instrm\*** Application Insights 계정을 선택합니다.

    1.  **검토 + 만들기**를 선택합니다.

1.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

1.  지정된 구성을 사용하여 웹앱을 만들려면 **만들기**를 선택합니다.

1.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

1. 포털의 왼쪽 네비게이션 페인에서 **리소스 그룹**을 선택합니다.

1. **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 선택합니다.

1. **MonitoredAssets** 블레이드에서, 이 랩의 앞에서 만든 **smpapi\*** 웹앱을 선택합니다.

1. **App Service** 블레이드의 왼쪽에 있는 **설정** 범주에서 **구성** 링크를 선택합니다.

1.  **구성** 섹션에서 다음 작업을 수행합니다.
    
    1.  **애플리케이션 설정** 탭을 선택합니다.

    1.  API와 연결된 비밀을 보려면 **값 표시**를 선택합니다.

    1.  **APPINSIGHTS\_INSTRUMENTATIONKEY** 키에 해당하는 값을 관찰합니다. 이 값은 웹앱 리소스를 빌드할 때 자동으로 설정되었습니다.

1. **App Service** 블레이드의 왼쪽에 있는 **설정** 범주에서 **속성** 링크를 선택합니다.

1. **속성** 섹션에서 **URL** 필드의 값을 기록합니다. 이 값을 나중에 랩에서 사용하여 API에 요청을 합니다.

#### 작업 4: 웹앱 자동 크기 조정 옵션 구성

1.  **App Service** 블레이드의 왼쪽에 있는 **설정** 범주에서 **규모 확장(App Service 계획)** 링크를 선택합니다.

1.  **규모 확장** 섹션에서 다음 작업을 수행합니다.
    
    1.  **사용자 지정 자동 크기 조정**을 선택합니다.
    
    1.  **자동 크기 조정 설정 이름** 필드에 **ComputeScaler**를 입력합니다.
    
    1.  **리소스 그룹** 목록에서 **모니터링 자산**을 선택합니다.
    
    1.  **스케일 모드** 섹션에서 **메트릭에 따라서 스케일**을 선택합니다.
    
    1.  **인스턴스 제한** 섹션 내의 **최소**필드에 **2**를 입력합니다.
    
    1.  **인스턴스 제한** 섹션 내의 **최대** 필드에 **8**을 입력합니다.
    
    1.  **인스턴스 제한** 섹션 내의 **기본** 필드에 **3**을 입력합니다.
    
    1.  **규칙 추가**를 선택합니다. 표시되는 **스케일 규칙** 팝업 창에서 모든 필드를 기본값으로 설정하고 **추가**를 선택합니다.
    
    1.  섹션 상단의 **저장**을 선택합니다.

1.  이 랩을 진행하기 전에 저장 작업이 완료될 때까지 기다립니다.

#### 검토

이 연습에서는 랩의 나머지 부분에 사용할 리소스를 만들었습니다.

### 연습 2: .NET Core 웹 API 애플리케이션 빌드 및 배포

#### 작업 1: .NET 코어 웹 API 프로젝트 빌드

1.  작업 표시줄에서 **Visual Studio Code** 아이콘을 선택합니다.

1.  **파일** 메뉴에서 **폴더 열기**를 선택합니다.

1.  열리는 파일 탐색기 창에서 **Allfiles (F):\\Allfiles\\Labs\\05\\Starter\\Api**로 이동하여 **폴더 선택**을 선택합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭하고 **터미널에서 열기**를 선택합니다.

1.  오픈 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 현재 디렉터리에서 **SimpleApi**라는 새 .NET Core 웹 API 응용 프로그램을 만듭니다.

```
    dotnet new webapi --output . --name SimpleApi
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 현재 프로젝트에 **2.8.2** 버전의 **Microsoft.ApplicationInsights.AspNetCore** 패키지를 추가합니다.

```
    dotnet add package Microsoft.ApplicationInsights.AspNetCore --version 2.8.2
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```
    
#### 작업 2: HTTPS 를 사용하지 않도록 설정하고 응용 프로그램 인사이트를 사용하도록 응용 프로그램 코드를 업데이트합니다.

1.  **Visual Studio Code** 창의 왼쪽에 있는 **탐색기** 창에서 **Startup.cs** 파일을 두 번 클릭하여 편집기에서 파일을 엽니다.

1.  편집기에서 **Startup** 클래스 내 **43**줄에 있는 다음 코드 줄을 찾아 삭제합니다.

```
    app.UseHttpsRedirection();
```

    > **참고**: 이 코드 줄은 웹앱이 HTTPS를 사용하도록 강제합니다. 이 랩에서는 이 작업을 사용할 필요가 없습니다.

1.  **Startup** 클래스 내에서, 이 랩의 앞에서 만든 **Application Insights** 리소스에서 복사한 **계측 키**로 값이 설정된 **INSTRUMENTATION_KEY**라는 새 **정적 문자열 상수**를 추가합니다.

```
    private const string INSTRUMENTATION_KEY = "{your_instrumentation_key}";
```

    > **참고**: 예를 들어 **계측 키**가 ``d2bb0eed-1342-4394-9b0c-8a56d21aaa43``이면 코드 줄은 ``private const string INSTRUMENTATION_KEY = "d2bb0eed-1342-4394-9b0c-8a56d21aaa43";``이 됩니다.

1.  **Startup** 클래스 내에서 **ConfigureServices** 메서드를 찾습니다.

```
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);        
    }
```

1.  **ConfigureServices** 메서드 끝에 새 코드 줄을 추가함으로써 제공된 계측 키를 사용하여 Application Insights를 구성합니다.

```    
    services.AddApplicationInsightsTelemetry(INSTRUMENTATION_KEY);
```

1.  **ConfigureServices** 메서드는 이제 다음과 같이 보입니다.

```
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);   
        services.AddApplicationInsightsTelemetry(INSTRUMENTATION_KEY);        
    }
```

1.  **Startup.cs** 파일을**저장합니다**.

1.  화면 하단의 명령 프롬프트로 이동합니다. 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 .NET Core 웹 응용 프로그램을 빌드합니다.

```
    dotnet build
```

#### 작업 3: API 응용 프로그램을 로컬로 테스트

1.  화면 아래쪽의 거북이를 보세요. 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 .NET Core 웹 응용 프로그램을 실행합니다.

```
    dotnet run
```
1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

1.  열린 브라우저 창에서 포트 **5000**의 **localhost**에서 호스팅되는 테스트 응용 프로그램의 **/api/value** 상대 경로로 이동합니다.
    
    > **참고**: 전체 URL 이 http://localhost:5000/api/values.

1.  동일한 브라우저 창에서 포트 **5000**의 **localhost**에서 호스팅되는 테스트 응용 프로그램의 **/api/values/7** 상대 경로로 이동합니다.
    
    >  **참고**: 전체 URL 이 http://localhost:5000/api/values/7

1.  http://localhost:5000/api/values/7 주소를 표시하는 브라우저 창을 닫습니다.

1.  현재 실행 중인 **Visual Studio 코드** 응용 프로그램을 닫습니다.

#### 작업 4: 응용 프로그램 인사이트 메트릭 보기

1.  **Azure 포털**을 표시하는 현재 열려있는 브라우저 창으로 돌아갑니다.

1.  포털의 왼쪽에서 **리소스 그룹**을 선택합니다.

1.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 찾아서 선택합니다.

1.  **모니터링된 자산** 블레이드에서 이전에 랩에서 만든 **instrm\*** 응용 프로그램 인사이트 계정을 선택합니다.

1.  **응용 프로그램 인사이트** 블레이드에서 블레이드 중앙에 있는 타일에서 표시된 메트릭을 관찰합니다. 특히 발생한 **서버 요청 수** 및 평균 **서버 응답 시간**을 확인합니다.

    > **참고**: Application Insights 메트릭 차트에 요청이 표시되는 데 최대 5분이 걸릴 수 있습니다.

#### 작업 5: 웹앱에 애플리케이션 배포

1.  작업 표시줄에서 **Visual Studio Code** 아이콘을 선택합니다.

1.  **파일** 메뉴에서 **폴더 열기**를 선택합니다.

1.  열리는 파일 탐색기 창에서 **Allfiles (F):\\Allfiles\\Labs\\Starter\\Api**로 이동하여 **폴더 선택**을 선택합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 Azure CLI에 로그인합니다.

```
    az login
```

1.  표시되는 브라우저 창에서 다음 작업을 수행합니다.
    
    1.  Microsoft 계정의 **전자 메일 주소**를 입력합니다.
    
    1.  **다음**을 선택합니다.
    
    1.  Microsoft 계정의 **비밀번호**를 입력합니다.
    
    1.  **로그인**을 선택합니다.

1.  현재 열려 있는 **명령 프롬프트** 응용 프로그램으로 돌아갑니다. 로그인 프로세스가 완료될 때까지 기다립니다.

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 **MonitoredAssets** 리소스 그룹의 모든 **어플**을 나열합니다.

```
    az webapp list --resource-group MonitoredAssets
```

1.  다음 명령을 입력하고 Enter 키를 눌러 접두사 **smpapi\***가 있는 **앱**을 찾습니다.

```
    az webapp list --resource-group MonitoredAssets --query "[?starts_with(name, 'smpapi')]"
```

1. 다음 명령을 입력하고 Enter 키를 눌러 접두사 **smpapi\***가 있는 단일 앱의 이름만 출력합니다.

```
    az webapp list --resource-group MonitoredAssets --query "[?starts_with(name, 'smpapi')].{Name:name}" --output tsv
```

1. 다음 명령을 입력하고 Enter 키를 눌러 현재 디렉터리를 배포 파일이 포함된 **Allfiles (F):\\Allfiles\\Labs\\05\\Starter** 디렉터리로 변경합니다,

```
    cd F:\Allfiles\Labs\05\Starter\
```

1. 다음 명령을 입력하고 Enter 키를 눌러 이 랩의 앞에서 만든 **웹앱**에 **api.zip** 파일을 배포합니다.

```
    az webapp deployment source config-zip --resource-group MonitoredAssets --src api.zip --name <name-of-your-api-app>
```

    > **참고**: **\<name-of-your-api-app\>** 자리 표시자를 이 랩의 앞에서 만든 웹앱의 이름으로 바꿉니다. 최근에 이전 단계에서 이 앱의 이름을 쿼리했습니다.

1. 이 랩을 진행하기 전에 배포가 완료될 때까지 기다립니다.

1. 현재 실행 중인 **Visual Studio Code** 응용 프로그램을 닫습니다.

1. 포털의 왼쪽 네비게이션 페인에서 **리소스 그룹**을 선택합니다.

1. **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 선택합니다.

1. **MonitoredAssets** 블레이드에서, 이 랩의 앞에서 만든 **smpapi\*** 웹앱을 선택합니다.

1. **App Service** 블레이드의 상단에서 **찾아보기**를 선택합니다.

1. 새 브라우저 창 또는 탭이 열리고 **404(찾을 수 없는)** 오류가 반환됩니다. 브라우저 주소 표시줄에서 현재 URL의 끝에 접미사 **/api/values**을 더하여 URL을 업데이트하고 Enter 를 누릅니다.

    > **참고**: 예를 들어 URL이 http://smpapistudent.azurewebsites.net인 경우 새 URL은 http://smpapistudent.azurewebsites.net/api/values가 됩니다.

1. API 를 사용하여 반환되는 JSON 배열을 관찰합니다.

#### 검토

이 연습에서는 ASP.NET Core를 사용하여 API를 만들고 애플리케이션 메트릭을 Application Insights로 스트리밍하도록 구성했습니다. 다음 Application Insights 대시보드를 사용하여 웹앱 및 앱에서 실행 중인 API에 대한 성능 세부 정보를 볼 수 있습니다.

### 연습 3: .NET Core를 사용하여 클라이언트 애플리케이션 빌드

#### 작업 1: .NET 코어 콘솔 프로젝트 빌드

1.  작업 표시줄에서 **Visual Studio Code** 아이콘을 선택합니다.

1.  **파일** 메뉴에서 **폴더 열기**를 선택합니다.

1.  열리는 파일 탐색기 창에서 **Allfiles (F):\\Allfiles\\Starter\\Console**로 이동하여 **폴더 선택**을 선택합니다.

1.  Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1.  오픈 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 현재 디렉터리에서 **SimpleConsole**이라는 새 .NET Core 콘솔 응용 프로그램을 만듭니다.

```
    dotnet new console --output . --name SimpleConsole
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 NuGet에서 현재 프로젝트에 **7.1.0** 버전의 **Polly** 패키지를 추가합니다.

```
    dotnet add package Polly --version 7.1.0
```

1.  명령 프롬프트에서 다음 명령을 입력하고 Enter 키를 눌러 .NET Core 웹 애플리케이션을 빌드합니다.

```
    dotnet build
```

#### 작업 2: HTTP 클라이언트 코드 추가

1.  **Visual Studio Code** 창의 왼쪽에 **탐색기** 페인에서 **Program.cs** 파일을 두 번 클릭하여 편집기에서 파일을 엽니다.

1.  편집기에서 **System.Net.Http** 네임스페이스에 대한 다음 **using** 지시문을 추가합니다.

```
    using System.Net.Http;
```

1.  편집기에서 **System.Threading.Tasks** 네임스페이스에 대한 다음 **using** 지시문을 추가합니다.

```
    using System.Threading.Tasks;
```

1.  **SimpleConsole** 네임스페이스에서 **7**줄에서 다음 클래스를 찾습니다.

```
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
```

1.  **Program** 클래스의 코드를 다음 코드로 바꿉니다.

```
    class Program
    {
        private const string _api = "";
        private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };
    
        static void Main(string[] args)
        {
            Run().Wait();
        }
    
        static async Task Run()
        {
    
        }
    }
```

1.  **9** 줄에서 **\_api** 상수를 찾습니다.

```
    private const string _api = "";
```

1.  이 랩의 앞에서 기록한 웹앱의 **URL**에 변수 값을 설정하여 **\_api** 상수를 업데이트합니다.

    > **참고**: 예를 들어 URL이 http://smpapistudent.azurewebsites.net인 경우 새 코드 줄은 private const string \_api = “http://smpapistudent.azurewebsites.net”입니다.

1.  **Run** 메서드 내에서 다음 코드 줄을 추가하여 **HttpClient.GetStringAsync** 메서드를 비동기적으로 호출하여 **/api/values/**의 상대 경로에 대한 문자열로 전달합니다.

```
    string response = await _client.GetStringAsync("/api/values/");
```

1.  **Run** 메서드 내에서 다음 코드 줄을 추가하여 **GET** 요청의 응답을 콘솔에 작성합니다.

```
    Console.WriteLine(response);
```

1. 이제 **Program.cs** 파일에 다음 코드가 있습니다.

```
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    namespace SimpleConsole
    {
        class Program
        {
            private const string _api = "http://<your-api-name>.azurewebsites.net/";
            private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) };
        
            static void Main(string[] args)
            {
                Run().Wait();
            }
        
            static async Task Run()
            {
                string response = await _client.GetStringAsync("/api/values/");
                Console.WriteLine(response);    
            }
        }
    }
```

1. **Program.cs** 파일을 **저장**합니다.

#### 작업 3: 콘솔 응용 프로그램 로컬 테스트

1.  화면 하단에서 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 .NET Core 웹 응용 프로그램을 실행합니다.

```
    dotnet run
```

1.  애플리케이션이 Azure에서 웹앱을 성공적으로 호출하고 이 랩의 앞에서 관찰한 것과 동일한 JSON 배열을 반환하는지 확인합니다. 결과는 다음 JSON 내용과 유사합니다.

```
    ["value1","value2"]
```

1.  **Azure Portal**을 표시하며 현재 열려 있는 브라우저 창으로 돌아갑니다.

1.  포털의 왼쪽에서 **리소스 그룹**을 선택합니다.

1.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 찾아서 선택합니다.

1.  **MonitoredAssets** 블레이드에서, 이 랩의 앞에서 만든 **smpapi\*** 웹앱을 선택합니다.

1.  **App Service** 블레이드의 상단에서 **중지**를 선택하여 웹앱 실행을 중지합니다.

1.  **웹앱 중지** 확인 대화 상자에서 **예**를 선택합니다.

1.  작업 표시줄에서 **Visual Studio Code** 아이콘을 선택합니다.

1. **파일** 메뉴에서 **폴더 열기**를 선택합니다.

1. 열리는 파일 탐색기 창에서 **Allfiles (F):\\Allfiles\\Labs\\05\\Starter\\Console**로 이동하여 **폴더 선택**을 선택합니다.

1. Visual Studio Code 창에서 컨텍스트 메뉴에 액세스하거나 **탐색기** 창을 마우스 오른쪽 단추로 클릭한 다음 **터미널에서 열기**를 선택합니다.

1. 열린 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 .NET Core 웹 응용 프로그램을 실행합니다.

```
    dotnet run
```

1. 애플리케이션 실행이 실패하고 다음 예외 메시지와 유사한 **HttpRequestException** 메시지가 표시되는지 확인하십시오.

```
    System.Net.Http.HttpRequestException: Response status code does not indicate

    success: 403 (Site Disabled).

    at System.Net.Http.HttpResponseMessage.EnsureSuccessStatusCode()

    at System.Net.Http.HttpClient.GetStringAsyncCore(Task\`1 getTask)

    at SimpleConsole.Program.Run() in F:\Allfiles\Labs\05\Starter\Console\Program.cs:line 20
```

    > **참고**: 이 예외는 웹앱을 더 이상 사용할 수 없기 때문에 발생합니다.

#### 작업 4: 폴리를 사용하여 재시도 논리 추가

1.  **Visual Studio Code**창의 왼쪽에 **탐색기** 페인에서 **PollyHandler.cs** 파일을 두 번 클릭하여 편집기에서 파일을 엽니다.

1.  **폴리핸들러** 클래스 내에서 **13-24**줄을 관찰합니다. 이러한 코드 줄은 **NET Foundation**의 **Polly** 라이브러리를 사용하여 5분마다 실패한 HTTP 요청을 다시 시도하는 재시도 정책을 만듭니다.

1.  **Visual Studio Code** 창의 왼쪽에 **탐색기** 페인에서 **Program.cs** 파일을 두 번 클릭하여 편집기에서 파일을 엽니다.

1.  **10**줄에서 **\_client** 상수를 찾습니다.

```
    private static HttpClient _client = new HttpClient(){ BaseAddress = new Uri(_api) }; 
```

1.  **PollyHandler** 클래스의 새 인스턴스를 사용하도록 **HttpClient** 생성자를 업데이트하여 **\_client** 상수를 업데이트합니다.

```
    private static HttpClient _client = new HttpClient(new PollyHandler()){ BaseAddress = new Uri(_api) };
```

1.  **Program.cs** 파일을 **저장**합니다.

#### 작업 5: 재시도 논리 검증

1.  화면 하단에서 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 .NET Core 웹 응용 프로그램을 실행합니다.

```
    dotnet run
```

1.  HTTP 요청 실행이 계속 실패하고 5초마다 다시 시도되는지 관찰합니다. 응용 프로그램이 실패하는 동안 콘솔에서 다음 메시지가 표시됩니다.

```
    Failed Attempt
```

1.  콘솔 애플리케이션을 실행 상태로 둡니다. 성공할 때까지 웹앱에 무한히 액세스하려고 시도합니다.

1.  **Azure Portal**을 표시하며 현재 열려 있는 브라우저 창으로 돌아갑니다.

1.  포털의 왼쪽에서 **리소스 그룹**을 선택합니다.

1.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 찾아서 선택합니다.

1.  **MonitoredAssets** 블레이드에서, 이 랩의 앞에서 만든 **smpapi\*** 웹앱을 선택합니다.

1.  **App Service** 블레이드의 상단에서 **시작**을 선택하여 웹앱을 다시 시작합니다.

1.  **웹앱 중지** 확인 대화 상자에서 **예**를 선택합니다.

1. 현재 실행 중인 **Visual Studio Code** 응용 프로그램으로 돌아갑니다.

1. 애플리케이션이 Azure에서 웹앱을 마침내 성공적으로 호출하고 이 랩의 앞에서 관찰한 것과 동일한 JSON 배열을 반환하는지 확인합니다. 결과는 다음과 같은 JSON 내용과 유사합니다.

```
    ["value1","value2"]
```

1. 현재 실행 중인 **Visual Studio Code** 애플리케이션을 닫습니다.

#### 검토

이 연습에서는 조건부 재시도 논리를 사용하여 API에 액세스하는 콘솔 애플리케이션을 만들었습니다. 웹앱을 사용할 수 있는지 여부에 관계없이 애플리케이션이 계속 작동했습니다.

### 연습 4: 웹앱 로드 테스트

#### 작업 1: 웹앱에서 성능 테스트 실행

1.  **Azure Portal**을 표시하며 현재 열려 있는 브라우저 창으로 돌아갑니다.

1.  포털의 왼쪽에서 **리소스 그룹**을 선택합니다.

1.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **MonitoredAssets** 리소스 그룹을 찾아서 선택합니다.

1.  **MonitoredAssets** 블레이드에서, 이 랩의 앞에서 만든 **smpapi\*** 웹앱을 선택합니다.

1.  **App Service** 블레이드의 왼쪽에 있는 **개발 도구** 범주에서 **성능 테스트**를 선택합니다.

1.  **성능 테스트** 섹션에서 섹션 상단에서 **신규**를 선택합니다.

1.  **새 성능 테스트** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **이름** 필드에 **부하 테스트**를 입력합니다.
    
    1.  **부하 생성 원본** 목록에서 **미국 동부(웹 앱 위치)**를 선택합니다.
    
    1.  **사용자 부하** 필드에 **1000**을 입력합니다.
    
    1.  **지속 시간** 필드에 **10**을 입력합니다.
    
    1.  **배치 테스트 사용**을 선택합니다.

1.  **배치 테스트 사용** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **테스트 유형** 목록에서 **수동 테스트**를 선택합니다.
    
    1.  **URL** 필드에서 현재 URL 끝에 접미사 **/api/values**을 추가하여 URL 을 업데이트합니다.

        > **참고**: 예를 들어 URL이 http://smpapistudent.azurewebsites.net인 경우 새 URL은 http://smpapistudent.azurewebsites.net/api/values가 됩니다.

    1.  **완료**를 선택합니다.

1.  **새 성능 테스트** 블레이드에서 **테스트 실행**을 선택합니다.

1.  **성능 테스트** 섹션으로 돌아가서 **최근 실행** 목록에서 **부하 테스트**를 선택합니다.

1. **부하 테스트** 블레이드에서 랩을 진행하기 전에 테스트가 시작될 때까지 기다립니다.

    > **참고**: 대부분의 로드 테스트는 리소스를 수집하고 시작하는 데 약 10~15분이 걸립니다. 부하 테스트가 시작되면 자동으로 새로 고쳐지므로 이 블레이드에서 기다릴 수 있습니다.

1. 랩을 진행하기 전에 부하 테스트가 완료될 때까지 기다립니다. 웹앱 사용량이 증가함에 따라 라이브 차트가 업데이트되는지 확인합니다.

    > **참고**: 부하 테스트는 이전에 랩의 단계에서 지정한 10 분 정도 걸립니다.

#### 작업 2: 성능 테스트 후 Azure 모니터 메트릭 사용

1.  Azure 포털의 왼쪽 네비게이션 페인에서 **모든 서비스**를 선택합니다.

1.  **모든 서비스** 블레이드에서 **모니터**를 선택합니다.

1.  **모니터** 블레이드에서 블레이드의 왼쪽에 **메트릭**을 선택합니다.

1.  **메트릭** 섹션에서 다음 작업을 수행합니다.
    
    1.  **리소스** 섹션에서 ** 리소스 선택**을 선택합니다.
    
    1.  **리소스 그룹** 목록에서 나타나는 **리소스 선택** 창에서 **모니터링된 자산**을 선택합니다. **리소스**목록에서 **instrm\*** 응용 프로그램 인사이트 계정 옵션을 선택합니다. 마지막으로 **적용**을 선택하여 창을 닫고 선택 사항을 확인합니다.
    
    1.  **메트릭 네임스페이스** 목록에서 **표준** 범주에 있는 **표준 메트릭(미리 보기)**을 선택합니다.
    
    1.  **메트릭** 목록의 **성능 카운터** 범주에서 **프로세스 CPU**를 선택합니다.
    
    1.  **취합** 목록에서 **평균**을 선택합니다.
    
    1.  섹션 상단에서 **마지막 24시간(자동 - 5분)**을 선택합니다. 표시되는 창의 **시간 범위** 범주에서 **마지막 30분**을 선택하고 **적용**을 선택하여 저장합니다.
    
    1.  섹션 상단에서 **라인 차트**를 선택합니다. 표시되는 메뉴에서 **영역 차트**를 선택합니다.

1.  새로 만든 차트를 관찰합니다.

1.  메시지 위쪽에서 **메트릭 추가**를 클릭합니다.

1.  **메트릭** 섹션에서 목록의 새 메트릭 항목을 통해 다음 작업을 수행합니다.
    
    1.  **메트릭 네임스페이스** 목록에서 **표준 범주**에서 **로그 기반 메트릭**을 선택합니다.
    
    1.  **메트릭** 목록에서**서버** 범주에서 **서버 응답**시간을 선택합니다.
    
    1. **취합**목록에서 **평균**을 선택합니다.

1.  업데이트된 차트를 관찰합니다. 차트에 표시된 정보를 관찰합니다. 서버 응답 시간이 응용 프로그램의 로드가 증가함에 따라 CPU 시간과 어떻게 상관 관계가 있는지 관찰할 수 있습니다.

#### 복습

이 연습에서는 Azure 에서 사용할 수 있는 도구를 사용하여 웹앱의 성능(로드) 테스트를 수행했습니다. 로드 테스트를 수행한 후 Azure Monitor 인터페이스의 메트릭을 사용하여 API 앱의 동작을 측정할 수 있었습니다.

### 연습 5: 구독 정리 

#### 작업 1: Cloud Shell 열기

1.  Azure Portal 상단에서 **Cloud Shell** 아이콘을 선택하여 새 셸 인스턴스를 엽니다.

    > **참고**: **Cloud Shell** 아이콘은 기호보다 큰 기호 및 밑줄 문자로 표시됩니다.

1.  구독을 사용하여 **Cloud Shell**을 처음 여는 경우 처음 사용 시 **Cloud Shell**을 구성할 수 있는 **Azure Cloud Shell 마법사 시작** 화면이 나타납니다. 마법사에서 다음 작업을 수행합니다.
    
    1.  셸 사용을 시작하도록 새 스토리지 계정을 만들라는 메시지가 대화 상자에 표시됩니다. 기본 설정을 수락하고 **저장소 만들기**를 선택합니다.
    
    1.  랩으로진행하기 전에 **Cloud Shell**이 첫 번째 설치 절차를 완료할 때까지 기다립니다.

    > **참고**: **Cloud Shell**에 대한 구성 옵션이 표시되지 않으면 이 과정의 랩에서 기존 구독을 사용하고 있기 때문일 수 있습니다. 랩은 새 구독을 사용 한다는 가정에서 작성됩니다.

1.  **Cloud Shell** 명령 프롬프트의 포털 하단에 다음 명령을 입력하고 Enter 키를 눌러 구독의 모든 리소스 그룹을 나열합니다.

```
    az group list
```

1.  다음 명령을 입력하고 Enter 키를 눌러 리소스 그룹을 삭제하는 데 사용할 수 있는 명령 목록을 봅니다.

```
    az group delete --help
```

#### 작업 2: 리소스 그룹 삭제

1.  다음 명령을 입력하고 Enter 를 눌러 **MonitoredAssets** 리소스 그룹을 삭제합니다.

```
    az group delete --name MonitoredAssets --no-wait --yes
```
    
1.  포털 하단의 **Cloud Shell** 창을 닫습니다.

#### 작업 3: 활성 애플리케이션 닫기

1.  현재 실행 중인 **Microsoft Edge** 응용 프로그램을 닫습니다.

1.  현재 실행 중인 **Visual Studio Code** 응용 프로그램을 닫습니다.

#### 검토

이 연습에서는 이 랩에 사용된 **리소스 그룹**을 제거하여 구독을 정리했습니다.
