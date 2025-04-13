# Design Patterns Multi-Language Implementation

이 프로젝트는 주요 디자인 패턴들을 C++, C#, Kotlin 세 가지 언어로 구현한 예제입니다. 각 언어별로 다음 디자인 패턴이 구현되어 있습니다:

1. 어댑터 패턴 (Adapter Pattern)
2. 데코레이터 패턴 (Decorator Pattern)
3. 파사드 패턴 (Facade Pattern)
4. 팩토리 패턴 (Factory Pattern)
5. 빌더/메소드 체이닝 패턴 (Builder/Method Chaining Pattern)

## 프로젝트 구조

```
design-patterns-multilang/
├── cpp/           # C++ 구현
├── csharp/        # C# 구현
├── kotlin/        # Kotlin 구현
└── .github/       # GitHub Actions 워크플로우
```

## 빌드 및 실행 방법

### C++

```bash
# 빌드
cd cpp
mkdir build && cd build
cmake ..
make

# 실행
./bin/adapter
./bin/decorator
./bin/facade
./bin/factory
./bin/builder
```

### C#

```bash
# 빌드
cd csharp
dotnet build

# 실행
dotnet run
```

### Kotlin

```bash
# 빌드
cd kotlin
./gradlew build

# 실행
./gradlew run
```

## 자동화 빌드

이 프로젝트는 GitHub Actions를 사용하여 자동화된 빌드 및 릴리즈 프로세스를 구현하고 있습니다:

1. `main` 브랜치로 푸시하거나 PR이 생성되면 자동으로 빌드가 시작됩니다.
2. C++, C#, Kotlin 프로젝트가 각각 빌드됩니다.
3. `main` 브랜치로의 푸시인 경우, 빌드된 모든 바이너리가 포함된 릴리즈가 자동으로 생성됩니다.

## 디자인 패턴 설명

### 어댑터 패턴 (Adapter Pattern)

외부 라이브러리 등에서 가져온 클래스 등 변경이 어려운 클래스의 메소드를 다른 클래스와 연결해주는 패턴입니다.

### 데코레이터 패턴 (Decorator Pattern)

기존의 객체에 새로운 기능을 추가할 수 있도록 구성하는 패턴입니다.

### 파사드 패턴 (Facade Pattern)

다양한 객체들을 단순한 인터페이스로 통합하여 다루기 쉽게 만드는 패턴입니다.

### 팩토리 패턴 (Factory Pattern)

객체 생성을 서브클래스에 위임하는 패턴입니다.

### 빌더/메소드 체이닝 패턴 (Builder/Method Chaining Pattern)

객체의 각 메소드가 자기 자신을 반환하는 패턴으로, 연속적인 메소드 호출을 가능하게 합니다.
