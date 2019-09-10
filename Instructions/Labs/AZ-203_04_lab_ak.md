---
랩:
    제목: '랩: 서비스 전반에서 리소스 비밀에 안전하게 액세스합니다'
    유형: '답변 키'
    모듈: ‘모듈 4: Azure 보안 구현'
---

# 랩: 서비스 전반에서 리소스 비밀에 안전하게 액세스
# 학생 랩 답변 키

## 마이크로소프트 Azure 사용자 인터페이스

Microsoft 클라우드 도구의 동적 특성을 감안할 때 이 교육 콘텐츠를 개발한 후 Azure 사용자 인터페이스(UI) 변경 사항이 발생할 수 있습니다. 이러한 변경으로 인해 랩 지침 및 랩 단계가 일치하지 않을 수 있습니다.

Microsoft 는 커뮤니티에서 필요한 변경 사항을 가져오는 즉시 이 교육 과정을 업데이트합니다. 그러나 클라우드 업데이트가 자주 발생하기 때문에 이 교육 콘텐츠가 업데이트되기 전에 UI가 변경될 수 있습니다. **이 경우 변경 사항에 적응하고 필요에 따라 랩에서 작업합니다.**

## 지침

### 시작하기 전에

#### 랩 가상 기계에 로그인

  - 다음 자격 증명을 사용하여 **Windows 10** 가상 기계에 로그인합니다.
    
      - **사용자 이름**: 관리자
    
      - **비밀번호**: Pa55w.rd

> > **참고**: 랩 가상 기계 로그인 지침은 교수자가 제공합니다.

#### 설치된 응용 프로그램 검토

  - **Windows 10** 바탕 하단에 있는 작업 표시줄을 관찰합니다. 작업 표시줄에는 이 랩에서 사용할 응용 프로그램에 대한 아이콘이 포함되어 있습니다.
    
      - 마이크로소프트 에지
    
      - 파일 탐색기

#### 랩 파일 다운로드

1.  작업 표시줄에서 **Windows PowerShell** 아이콘을 선택합니다.

2.  PowerShell 명령 프롬프트에서 현재 작업 디렉토리를 **Allfiles(F):\\** 경로로 변경합니다.

    ```
    cd F:
    ```

3.  명령 프롬프트 내에서 다음 명령을 입력하고 **랩파일** 디렉토리로 GitHub 에서 호스팅되는 **microsoftlearning/AZ-203-DevelopingSolutionsForAzure** 프로젝트를 복제하기 위해 Enter 를 누릅니다.

    ```
    git clone --depth 1 --no-checkout https://github.com/microsoftlearning/AZ-203-DevelopingSolutionsForMicrosoftAzure .
    ```

4.  명령 프롬프트 내에서 다음 명령을 입력하고 **AZ-203.02** 랩을 완료하기 위해 필요한 랩 파일을 체크 아웃하여 **Enter** 를 누릅니다.

    ```
    git checkout master -- Allfiles/*
    ```

5.  현재 실행 중인 **Windows PowerShell** 명령 프롬프트 응용 프로그램을 닫습니다.

### 연습 1: Azure 리소스 만들기

#### 작업 1: Azure portal 열기

1.  작업 표시줄에서 **Microsoft Edge** 아이콘을 선택합니다.

2.  열린 브라우저 창에서 ****Azure portal**** ([portal.azure.com](https://portal.azure.com))로 이동합니다.

3.  Microsoft 계정의 **전자 메일 주소** 를 입력합니다.

4.  **다음** 을 선택합니다.

5.  Microsoft 계정의 **비밀번호** 를 입력합니다.

6.  **로그인** 을 선택합니다.

> > 참고: **Azure Portal** 에 처음 로그인하는 경우 포털 둘러보기를 제공하는 대화 박스가 나타납니다. 둘러보기를 건너뛰고 포털 사용을 시작하려면 **시작하기** 를 선택합니다.

#### 작업 2: Azure 저장소 계정 만들기

1.  Azure portal 의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스를** 선택합니다.

2.  **모든 서비스** 블레이드에서 **저장소 계정** 을 선택합니다.

3.  **저장소 계정** 블레이드에서 저장소 인스턴스 목록을 봅니다.

4.  **저장소 계정** 블레이드 상단에서 **추가** 를 선택합니다.

5.  **저장소 계정 만들기** 블레이드에서 **기본** 사항과 같은 블레이드 상단의 탭을 관찰합니다.

> 참고: 각 탭은 새 **저장소 계정** 을 만드는 워크플로의 단계를 나타냅니다. 언제든지 **검토 + 만들기** 를 선택하여 나머지 탭을 건너뛸 수 있습니다.

6.  **기본** 탭에서 다음 작업을 수행합니다.
    
    1.  **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    2.  **리소스 그룹** 섹션에서 **새 만들기** 를 선택하고 **SecureFunction** 을 입력한 다음 **확인** 을 선택합니다.
    
    3.  **저장소 계정** **이름** 텍스트 박스에 **securestor\[소문자로 이름\]** 을 입력합니다.
    
    4.  **위치** 드롭다운 목록에서 **미국 동부** 지역을 선택합니다.
    
    5.  **성능** 섹션에서 **표준** 을 선택합니다.
    
    6.  **계정 종류** 드롭다운 목록에서 **StorageV2(일반용v2)** 를 선택합니다.
    
    7.  **복제** 드롭다운 목록에서 **로컬 중복 저장소(LRS)** 를 선택합니다.
    
    8.  **액세스 계층** 섹션에서 **핫** 가 선택되어 있는지 확인합니다.
    
    9.  **검토 + 만들기** 를 선택합니다.

7.  **검토 + 만들기** 탭에서 이전 단계에서 선택한 옵션을 검토합니다.

8.  지정된 구성을 사용하여 저장소 계정을 만들려면 **만들기** 를 선택합니다.

9.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

10. Azure portal 의 왼쪽에 있는 네비게이션 페인에서 **모든 서비스를** 선택합니다.

11. **모든 서비스** 블레이드에서 **저장소 계정** 을 선택합니다.

12. **저장소 계정** 블레이드에서 접두사 **securestor** 가 있는 저장소 계정 인스턴스를 선택합니다.

13. **저장소 계정** 블레이드에서 블레이드 왼쪽에 있는 **설정** 섹션을 찾아 **액세스 키** 링크를 선택합니다.

14. **Access 키** 블레이드에서 키 중 하나를 선택하고 **연결 문자열** 필드 중 하나에서 값을 기록합니다. 이 랩의 나중에 이 값을 사용합니다.

> > 참고: 어떤 연결 문자열을 사용하든 상관없습니다. 서로 교환할 수 있습니다.

#### 작업 3: Azure 키 볼트 만들기

1.  포털 왼쪽에 있는 네비게이션 메뉴에서 **+ 리소스 만들기** 링크를 선택합니다.

2.  **새** 블레이드 상단에서 피처 서비스 목록 위의 **마켓플레이스 검색 텍스트** 박스를 찾습니다.

3.  검색 텍스트 박스에서 **볼트** 를 입력한 다음 Enter 를 누릅니다.

4.  **모든** 검색 결과 블레이드에서 **키 볼트** 결과를 선택합니다.

5.  **키 볼트** 블레이드에서 **만들기** 를 선택합니다.

6.  **키 볼트 만들기** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **이름** 텍스트 박스에 **securevault\[소문자로 이름\] ** 을 입력합니다.
    
    2.  **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    3.  **리소스 그룹** 섹션에서 **기존 사용** 을 선택한 다음 목록에서 **SecureFunction** 을 선택합니다.
    
    4.  **위치** 드롭다운 목록에서 **미국 동부** 를 선택합니다.
    
    5.  **가격 계층** 텍스트 박스를 기본값으로 설정한 상태로 둡니다.
    
    6.  **Access 정책** 텍스트 박스를 기본값으로 설정한 상태로 둡니다.
    
    7.  **가상 네트워크 액세스** 텍스트 박스를 기본값으로 설정한 상태로 둡니다.
    
    8.  **만들기** 를 선택합니다.

7.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

#### 작업 4: Azure 함수 어플 만들기

1.  포털 왼쪽에 있는 네비게이션 메뉴에서 **+ 리소스 만들기** 링크를 선택합니다.

2.  **새** 블레이드 상단에서 피처 서비스 목록 위의 **마켓플레이스 검색** 텍스트 박스를 찾습니다.

3.  검색 텍스트 박스에서 **함수** 를 입력한 다음 Enter 를 누릅니다.

4.  **모든** 검색 결과 블레이드에서 **함수 어플** 결과를 선택합니다.

5.  **함수 어플** 블레이드에서 **만들기** 를 선택합니다.

6.  **함수 어플 만들기** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **어플 이름** 텍스트 박스에 **securefunc\[소문자로 이름\]** 을 입력합니다.
    
    2.  **구독** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    3.  **리소스 그룹** 섹션에서 **기존 사용** 을 선택한 다음 목록에서 **SecureFunction** 을 선택합니다.
    
    4.  **OS** 섹션에서 **Windows** 를 선택합니다.
    
    5.  **호스팅 계획** 드롭다운 목록에서 **소비 계획** 을 선택합니다.
    
    6.  **위치** 드롭다운 목록에서 **미국 동부** 를 선택합니다.
    
    7.  **런타임 스택** 드롭다운 목록에서 **.NET** 을 선택합니다.
    
    8.  **저장소** 섹션에서 **기존 사용** 을 선택한 다음 목록에서 **securestor\[소문자에서 이름\]** 을 선택합니다.
    
    9.  **Application Insights** 텍스트 박스를 기본값으로 설정합니다.
    
    10. **만들기** 를 선택합니다.

7.  이 랩을 진행하기 전에 만들기 작업이 완료될 때까지 기다립니다.

#### 검토

이 연습에서는 이 랩에 사용할 모든 리소스를 만들었습니다.

### 연습 2: 비밀 및 ID 구성 

#### 작업 1: 할당된 시스템 관리형 서비스 ID 구성

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securefunc\*** 함수 어플을 선택합니다.

4.  **함수 어플** 블레이드에서 **플랫폼 피처** 탭을 선택합니다.

5.  **플랫폼 피처** 탭에서 **네트워킹** 섹션에 있는 **ID** 링크를 선택합니다.

6.  **ID** 블레이드에서 **시스템 지정** 탭을 찾은 후에 다음 작업을 수행합니다.
    
    1.  **상태** 섹션에서 **On** 을 선택합니다.
    
    2.  **저장** 을 선택합니다.
    
    3.  확인 대화 박스에서 **예** 를 선택합니다.

7.  이 랩을 진행하기 전에할당된 시스템에서 관리되는 ID 가 만들어질 때까지 기다립니다.

#### 작업 2: 키 볼트 비밀 만들기

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securevault\*** 키 볼트를 선택합니다.

4.  **키 볼트** 블레이드에서 **설정** 섹션에 있는 **비밀** 링크를 선택합니다.

5.  **비밀** 페인에서 **생성/수입** 을 선택합니다.

6.  **비밀 만들기** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **업로드 옵션** 드롭다운 목록에서 **수동** 을 선택합니다.
    
    2.  **이름** 텍스트 박스에 **저장소 자격 증명** 을 입력합니다.
    
    3.  **값** 텍스트 박스에 이전에 랩에서 기록한 저장소 계정 **연결 문자열** 을 입력합니다.
    
    4.  **콘텐츠 유형** 텍스트 박스를 기본값으로 설정합니다.
    
    5.  **활성화 날짜 설정** 텍스트 박스를 기본값으로 설정한 상태로 둡니다.
    
    6.  **만료 날짜 설정** 텍스트 박스를 기본값으로 설정된 상태로 둡니다.
    
    7.  **사용 설정** 섹션에서 **예** 를 선택합니다.
    
    8.  **만들기** 를 선택합니다.

7.  이 랩으로 이동하기 전에 비밀이 만들어질 때까지 기다립니다.

8.  **비밀** 페인에서 목록의 **저장소 자격 증명** 항목을 선택합니다.

9.  **버전** 페인에서 **저장소 자격 증명** 비밀의 최신 버전을 선택합니다.

10. **비밀 버전** 페인에서 다음 작업을 수행합니다.
    
    9.  최신 버전의 보안 비밀에 대한 메타데이터를 관찰합니다.
    
    10. 비밀 값을 보려면 **비밀 값 표시** 를 선택합니다.
    
    11. 나중에 랩에서 이 값을 사용하기 때문에 **비밀 식별자** 텍스트 박스의 값을 기록합니다.

> > 참고: **비밀 값** 필드가 아닌 **비밀 식별자** 필드의 값을 기록하고 있습니다.

#### 작업 3: 키 볼트 액세스 정책 구성

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securevault\*** 키 볼트를 선택합니다.

4.  **키 볼트** 블레이드에서 **설정** 섹션에 있는 **액세스 정책** 링크를 선택합니다.

5.  **액세스 정책** 페인에서 **새 추가** 를 선택합니다.

6.  **액세스 추가 정책** 블레이드에서 다음 작업을 수행합니다.
    
    1.  **주 선택** 링크를 선택합니다.
    
    2.  **주** 블레이드에서 **securefunc\[소문자로 이름\]** 이라는 서비스 주체를 찾아 선택한 다음 **선택** 을 선택합니다.
    
    3.  **키 사용 권한** 목록을 기본값으로 설정합니다.
    
    4.  비밀 사용 권한 드롭다운 목록에서 GET 권한을 선택합니다.
    
    5.  **인증서 사용 권한** 목록을 기본값으로 설정합니다.
    
    6.  **승인된 응용 프로그램** 텍스트 박스를 기본값으로 설정합니다.
    
    7.  **확인** 을 선택합니다.

7.  **액세스 정책** 페인에서 **저장** 을 선택합니다.

8.  이 랩을 진행하기 전에 액세스 정책에 대한 변경 내용이 저장될 때까지 기다립니다.

#### 검토

이 연습에서는 함수 어플에 대해 할당된 서버에서 관리되는 서비스 ID 를 만든 다음 해당 ID 에 Key Vault 에서 비밀 값을 얻을 수 있는 적절 한 권한을 부여 했습니다. 마지막으로 함수 어플 내에서 사용할 비밀을 만들었습니다.

### 연습 3: 함수 어플 코드 작성 

#### 작업 1: 키 볼트 파생 응용 프로그램 설정 만들기 

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securefunc\*** 함수 어플을 선택합니다.

4.  **함수 어플** 블레이드에서 **플랫폼 피처** 탭을 선택합니다.

5.  **플랫폼 피처** 탭에서 **일반 설정** 섹션에 있는 **응용 프로그램 설정** 링크를 선택합니다.

6.  **응용 프로그램 설정** 탭에서 다음 작업을 수행합니다.
    
    1.  **용어 집합 설정** 섹션이 표시될 때까지 아래로 스크롤합니다.
    
    2.  **+새 설정 추가** 를 선택합니다.
    
    3.  **이름 입력** 텍스트 박스에서 **StorageConnectionString** 을 입력합니다.
    
    4.  **값 입력** 텍스트 박스에서 다음 구문을 사용하여 값을 생성합니다. **@Microsoft.KeyVault(SecretUri=\<Secret Identifier\>)**

> > 참고: 위의 구문을 사용하여 **비밀 식별자** 에 대한 참조를 작성해야 합니다. 예를 들어 비밀 식별자가 **https://securevaultstudent.vault.azure.net/secrets/storagecredentials/17b41386df3e4191b92f089f5efb4cbf** 경우 **@Microsoft.KeyVault(SecretUri= https://securevaultstudent.vault.azure.net/secrets/storagecredentials/17b41386df3e4191b92f089f5efb4cbf)** 값이 됩니다.

5.  **슬롯 설정** 텍스트 박스를 기본값으로 설정한 상태로 둡니다.

6.  탭 상단으로 다시 스크롤한 다음 **저장** 을 선택합니다.

<!-- end list -->

7.  이 랩을 진행하기 전에 응용 프로그램 설정이 유지될 때까지 기다립니다.

#### 작업 2: HTTP 트리거 함수 만들기

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securefunc\*** 함수 어플을 선택합니다.

4.  **함수 어플** 블레이드에서 **+ 새 함수** 를 선택합니다.

5.  **새 Azure Function** 빠른 시작에서 다음 작업을 수행합니다.
    
    1.  **개발 환경 선택** 헤더에서 **포털에** 를 선택합니다.
    
    2.  **계속** 을 선택합니다.
    
    3.  **함수 선택** 헤더에서 **더 많은 템플릿...** 을 선택합니다.
    
    4.  **템플릿 완료 및 보기** 를 선택합니다.
    
    5.  **템플릿** 드롭다운 목록에서 **HTTP 트리거** 를 선택합니다.
    
    6.  **새 함수** 팝업에서 **이름** 텍스트 박스를 찾아 **FileParser** 를 입력합니다.
    
    7.  **새 함수** 팝업에서 **권한 부여 수준** 목록을 찾아 **익명** 을 선택합니다.
    
    8.  **새 함수** 팝업에서 **만들기** 를 선택합니다.

6.  함수 편집기에서 예제 함수 스크립트를 관찰합니다.

\#r "Newtonsoft.Json”

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Primitives;

using Newtonsoft.Json;

public static async Task\<IActionResult\> Run(HttpRequest req, ILogger log)

{

log.LogInformation("C\# HTTP trigger function processed a request.");

string name = req.Query\["name"\];

string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

dynamic data = JsonConvert.DeserializeObject(requestBody);

name = name ?? data?.name;

return name \!= null

? (ActionResult)new OkObjectResult($"Hello, {name}")

: new BadRequestObjectResult("Please pass a name on the query string or in the request body");

}

7.  예제 코드를 모두 **삭제** 합니다.

8.  함수 편집기 내에서 다음 자리 표시자 함수를 복사하여 붙여넣습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

return new OkObjectResult("Test Successful");

}

9.  **저장 및 실행** 을 선택하여 스크립트를 저장하고 함수의 테스트 실행을 수행합니다.

10. 스크립트가 처음으로 실행될 때 **테스트** 및 **로그** 페인이 자동으로 나타납니다.

11. **테스트** 페인에서 **출력** 텍스트 박스를 관찰합니다. 이제 함수에서 반환된 **테스트 성공** 값이 표시됩니다.

#### 작업 3: 응용 프로그램 설정 테스트

1.  스크립트의 **Run** 메서드 내에서 기존 코드를 삭제합니다.

2.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

}

3.  다음 코드 줄을 추가하여 **Environment.GetEnvironmentVariable** 메서드를 사용하여 **StorageConnectionString** 응용 프로그램 설정의 값을 얻읍니다.

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

4.  다음 코드 줄을 추가하여 **OkObjectResult** 클래스 생성기를 사용하여 **connectionString** 변수의 값을 반환합니다.

return new OkObjectResult(connectionString);

5.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

return new OkObjectResult(connectionString);

}

6.  **저장 및 실행** 을 선택하여 스크립트를 저장하고 함수의 테스트 실행을 수행합니다.

7.  **테스트** 페인에서 **출력** 텍스트 박스를 관찰합니다. 이제 함수에서 반환된 연결 문자열이 표시됩니다.

#### 검토

이 연습에서는 서비스 ID 를 사용하여 **Azure Key Vault** 에 저장된 비밀의 값을 읽고 **Azure Function** 의 결과로 해당 값을 반환합니다.

### 연습 4: 저장소 계정 블랍에 액세스

#### 작업 1: 샘플 저장소 블랍 업로드

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securestor\*** 저장소 계정을 선택합니다.

4.  **저장소 계정** 블레이드에서 블레이드 왼쪽의 **블랍 서비스** 섹션에 있는 **블랍** 링크를 선택합니다.

5.  **블랍** 섹션에서 **+ 컨테이너** 를 선택합니다.

6.  **새 컨테이너** 팝업에서 다음 작업을 수행합니다.
    
    1.  **이름** 텍스트 박스에 **드롭** 를 입력합니다.
    
    2.  **공용 액세스 수준** 드롭다운 목록에서 **블랍(블랍에 대해서만 익명 읽기액세스)** 를 선택합니다.
    
    3.  **확인** 을 선택합니다.

7.  **블랍** 섹션으로 돌아가서 새로 만든 **드롭** 컨테이너를 선택합니다.

8.  **컨테이너** 블레이드에서 **업로드** 를 선택합니다.

9.  **블랍 업로드** 팝업에서 다음 작업을 수행합니다.
    
    4.  **파일** 섹션에서 **폴더** 아이콘을 선택합니다.
    
    5.  파일 네비게이션기 대화 박스에서 **Allfiles (F):\\Labfiles\\04\\Starter** 으로 이동하여 **records.json** 파일을 선택하고 **확인** 을 선택합니다.
    
    6.  **파일이 이미 있는지 덮어쓰기** 가 선택되어 있는지 확인합니다.
    
    7.  **업로드** 를 선택합니다.

10. 이 랩을 계속하기 전에 블랍이 업로드될 때까지 기다립니다.

11. **컨테이너** 블레이드에서 블랍 목록에서 **records.json** 블랍을 선택합니다.

12. **블랍** 블레이드에서 블랍 메타데이터를 봅니다.

13. 블랍의 **URL** 을 복사합니다.

14. 작업 표시줄에서 **Microsoft Edge** 아이콘을 오른쪽으로 선택한 다음 **새 창** 을 선택합니다.

15. 새 브라우저 창에서 블랍에 대해 복사한 **URL** 로 이동합니다.

16. 이제 블랍의 **JSON** 내용이 표시됩니다. **JSON** 내용을 표시하는 브라우저 창을 닫습니다.

17. **Azure portal** 을 사용하여 브라우저 창으로 돌아갑니다.

18. **블랍** 블레이드를 닫습니다.

19. **컨테이너** 블레이드로 돌아가서 블레이드 상단에 있는 **액세스 수준 정책 변경** 을 선택합니다.

20. 표시되는 **액세스 수준 변경** 팝업에서 다음 작업을 수행합니다.
    
    8.  **공용 액세스 수준** 드롭다운 목록에서 **비공개(익명 액세스없음)** 를 선택합니다.
    
    9.  **확인** 을 선택합니다.

21. 작업 표시줄에서 **Microsoft Edge** 아이콘을 오른쪽으로 선택한 다음 **새 창** 을 선택합니다.

22. 새 브라우저 창에서 블랍에 대해 복사한 **URL** 로 이동합니다.

23. 이제 리소스를 찾을 수 없다는 오류 메시지가 표시됩니다.

> > 참고: 오류 메시지가 표시되지 않으면 브라우저에서 파일을 캐치했을 수 있습니다. **Ctrl+F5** 를 사용하여 오류 메시지가 표시될 때까지 페이지를 새로 고칩니다.

#### 작업 2: 저장소 계정 SDK 구성

1.  포털의 왼쪽에 있는 네비게이션 메뉴에서 **리소스 그룹** 링크를 선택합니다.

2.  **리소스 그룹** 블레이드에서 이전에 랩에서 만든 **SecureFunction** 리소스 그룹을 찾아서 선택합니다.

3.  **SecureFunction** 블레이드에서 이전에 랩에서 만든 **securefunc\*** 함수 어플을 선택합니다.

4.  **함수 어플** 블레이드에서 기존 **FileParser** 함수를 찾아 선택하여 함수에 대한 편집기를 엽니다.

> > 참고: 블레이드 왼쪽의 메뉴에서 **함수** 옵션을 확장해야 할 수 있습니다.

5.  편집기의 오른쪽에서 **파일 보기** 를 선택하여 탭을 엽니다.

6.  **파일 보기** 탭에서 **업로드** 를 선택합니다.

7.  열리는 파일 네비게이션기 대화 박스에서 **Allfiles (F):\\Labfiles\\04\\Starter** 으로 이동하여 **function.proj** 파일을 선택하고 **열기** 를 선택합니다.

8.  **Function.proj** 파일을 선택하여 파일의 내용을 봅니다.

9.  **Run.csx ** 파일을 선택하여 **FileParser** 함수의 편집기로 돌아갑니다.

10. **파일 보기** 탭을 최소화합니다.

> > 참고: 탭 헤더의 오른쪽에 있는 화살표를 즉시 선택하여 탭을 최소화할 수 있습니다.

11. 편집기 내에서 스크립트의 **Run** 메서드 내에서 기존 코드를 삭제합니다.

12. 코드 파일 의 맨 위에 다음 코드 줄을 추가하여 **Microsoft.WindowsAzure.Storage** 네임스페이스에 대한 **사용** 블록을 만듭니다.

using Microsoft.WindowsAzure.Storage;

13. 다음 코드 줄을 추가하여 **Microsoft.WindowsAzure.Storage.Blob** 네임스페이스에 대한 **사용** 블록을 만듭니다.

using Microsoft.WindowsAzure.Storage.Blob;

14. 이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Blob;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

}

#### 작업 3: 저장소 계정 코드 작성

1.  **Run** 메서드에서 다음 코드 줄을 추가하여 **Environment.GetEnvironmentVariable** 메서드를 사용하여 **StorageConnectionString** 응용 프로그램 설정의 값을 얻읍니다.

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

2.  다음 코드 줄을 추가하여 **CloudStorageAccount.Parse** 스태틱 메서드를 사용하여 **CloudStorageAccount** 클래스의 새 인스턴스를 만들고 *연결문자열* 변수를 전달합니다.

CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);

3.  다음 코드 줄을 추가하여 **CloudStorageAccount.CreateCloudBlobClient** 메서드를 사용하여 저장소 계정의 블랍에 대한 액세스 권한을 부여하는 **CloudBlobClient** 클래스의 새 인스턴스를 만듭니다.

CloudBlobClient blobClient = account.CreateCloudBlobClient();

4.  다음 코드 줄을 추가하여 **CloudBlobClient.GetContainerReference** 메서드를 사용하고 **drop** 컨테이너 이름을 새이전에 랩에서 만든 컨테이너를 참조하는 **CloudBlobContainer** 클래스의 인스턴스로 전달하합니다.

CloudBlobContainer container = blobClient.GetContainerReference("drop");

5.  다음 코드 줄을 추가하여 **CloudBlobContainer.GetBlockBlobReference** 메서드를 사용하고 **records.json** 블랍 이름을 이전에 랩에서 업로드한 블랍을 참조하는 **CloudBlockBlob** 클래스의 새 인스턴스로 만드러 전달합니다.

CloudBlockBlob blob = container.GetBlockBlobReference("records.json");

6.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Blob;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);

CloudBlobClient blobClient = account.CreateCloudBlobClient();

CloudBlobContainer container = blobClient.GetContainerReference("drop");

CloudBlockBlob blob = container.GetBlockBlobReference("records.json");

}

#### 작업 4: 블랍 다운로드

1.  다음 코드 줄을 추가하여 참조된 블랍의 내용을 **CloudBlockBlob.DownloadTextAsync** 메서드를 사용하여 비동기적으로 다운로드하고 *콘텐츠* 라는 문자열 변수에 결과를 저장합니다.

string content = await blob.DownloadTextAsync();

2.  다음 코드 줄을 추가하여 **OkObjectResult** 클래스 생성기를 사용하여 *콘텐츠* 변수의 값을 반환합니다.

return new OkObjectResult(content);

3.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Blob;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);

CloudBlobClient blobClient = account.CreateCloudBlobClient();

CloudBlobContainer container = blobClient.GetContainerReference("drop");

CloudBlockBlob blob = container.GetBlockBlobReference("records.json");

string content = await blob.DownloadTextAsync();

return new OkObjectResult(content);

}

4.  **저장 및 실행** 을 선택하여 스크립트를 저장하고 함수의 테스트 실행을 수행합니다.

5.  **테스트** 페인에서 **출력** 텍스트 박스를 관찰합니다. 이제 **저장소 계정** 에 저장된 **$/drop/records.json** 블랍의 내용이 표시됩니다.

#### 작업 5: 공유 액세스 서명(SAS) 생성

1.  기존 코드 줄을 **삭제** 합니다.

string content = await blob.DownloadTextAsync();

return new OkObjectResult(content);

2.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Blob;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);

CloudBlobClient blobClient = account.CreateCloudBlobClient();

CloudBlobContainer container = blobClient.GetContainerReference("drop");

CloudBlockBlob blob = container.GetBlockBlobReference("records.json");

}

3.  다음 코드 줄을 추가하여다음 설정을 사용하여 **SharedAccessPolicy** 클래스의 새 인스턴스를 만듭니다.
    
      - **허가**: 읽기
    
      - **서비스 범위**: Blob
    
      - **리소스유형**: 개체
    
      - **만료 시간**: 2 시간
    
      - **프로토콜:** HTTPS 전용

SharedAccessAccountPolicy policy = new SharedAccessAccountPolicy()

{

Permissions = SharedAccessAccountPermissions.Read,

Services = SharedAccessAccountServices.Blob,

ResourceTypes = SharedAccessAccountResourceTypes.Object,

SharedAccessExpiryTime = DateTime.UtcNow.AddHours(2),

Protocols = SharedAccessProtocol.HttpsOnly

};

4.  다음 코드 줄을 추가하여 **CloudStorageAccount.GetSharedAcessSignature** 메서드를 사용하고 제공된 정책을 사용해서 새 **SAS(공유 액세스 서명)토큰** 을 생성하고 *sasToken* 라는문자열 변수에저장합니다:

string sasToken = account.GetSharedAccessSignature(policy);

5.  다음 코드 줄을 추가하여 **CloudBlockBlob.Uri** 속성 및 *sasToken* 문자열 변수의 값을 연결하고 *secureBlobUrl* 이라는 새 변수에 결과를 저장합니다:

string secureBlobUrl = $"{blob.Uri}{sasToken}";

6.  다음 코드 줄을 추가하여 **OkObjectResult** 클래스 생성기를 사용해서 *SecureBlobUrl* 변수의 값을 반환합니다.

return new OkObjectResult(secureBlobUrl);

7.  이제 **Run** 메서드는 다음과 같습니다.

using System.Net;

using Microsoft.AspNetCore.Mvc;

using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Blob;

public static async Task\<IActionResult\> Run(HttpRequest req)

{

string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");

CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);

CloudBlobClient blobClient = account.CreateCloudBlobClient();

CloudBlobContainer container = blobClient.GetContainerReference("drop");

CloudBlockBlob blob = container.GetBlockBlobReference("records.json");

SharedAccessAccountPolicy policy = new SharedAccessAccountPolicy()

{

Permissions = SharedAccessAccountPermissions.Read,

Services = SharedAccessAccountServices.Blob,

ResourceTypes = SharedAccessAccountResourceTypes.Object,

SharedAccessExpiryTime = DateTime.UtcNow.AddHours(2),

Protocols = SharedAccessProtocol.HttpsOnly

};

string sasToken = account.GetSharedAccessSignature(policy);

string secureBlobUrl = $"{blob.Uri}{sasToken}";

return new OkObjectResult(secureBlobUrl);

}

8.  **저장 및 실행** 을 선택하여 스크립트를 저장하고 함수의 테스트 실행을 수행합니다.

9.  **테스트** 페인에서 **출력** 텍스트 박스를 관찰합니다. 이제 보안 블랍에 액세스를 사용할 수 있는 유일한 **보안 URL** 이 표시됩니다. 이랩의 다음 단계에서 사용해야 하므로 이 **URL** 을 기록합니다.

10. 작업 표시줄에서 **Microsoft Edge** 아이콘을 오른쪽으로 선택한 다음 **새 창** 을 선택합니다.

11. 새 브라우저 창에서 블랍에 대해 복사한 **보안** **URL** 로 이동합니다.

12. 이제 블랍의 **JSON** 내용이 표시됩니다. **JSON** 내용을 표시하는 브라우저 창을 닫습니다.

13. **Azure portal** 을 사용하여 브라우저 창으로 돌아갑니다.

#### 검토

이 연습에서는 C\# 코드를 사용하여 저장소 계정에 안전하게 액세스하고, 블랍의 내용을 다운로드한 다음 다른 클라이언트에서 블랍에 안전하게 액세스를 사용할 수 있는 SAS 토큰을 생성했습니다.

### 연습 5: 구독 정리 

#### 작업 1: Azure 클라우드 셸 열기 및 리소스 그룹 나열

1.  Azure 포털 상단 네비게인션 바에서 **Cloud Shell** 아이콘을 선택하여 새 셸 인스턴스를 엽니다.

2.  포털 하단의 **Cloud Shell** 명령 프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 구독의 모든 리소스 그룹을 나열합니다.

az group list

3.  프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 리소스 그룹을 삭제할 수 있는 명령 목록을 봅니다.

az group delete --help

#### 작업 2: 그룹 만들기

1.  프롬프트에서 다음 명령을 입력하고 Enter 를 눌러 **SecureFunction** 리소스 그룹을 삭제합니다.

az group delete --name SecureFunction --no-wait --yes

2.  포털 하단의 **클라우드 셸** 페인을 닫습니다.

#### 작업 3: 액티브 응용 프로그램 닫기

> 현재 실행 중인 **Microsoft Edge** 응용 프로그램을 닫습니다.

#### 검토

이 연습에서는 이 랩에 사용된 **리소스 그룹** 을 제거하여 구독을 정리했습니다.
