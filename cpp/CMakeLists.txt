cmake_minimum_required(VERSION 3.10)
project(DesignPatterns)

set(CMAKE_CXX_STANDARD 17)

# 각 디자인 패턴별 실행 파일 생성
add_executable(adapter src/adapter.cpp)
add_executable(decorator src/decorator.cpp)
add_executable(facade src/facade.cpp)
add_executable(factory src/factory.cpp)
add_executable(builder src/builder.cpp)

# 모든 실행 파일을 patterns 그룹으로 묶기
set_target_properties(adapter decorator facade factory builder
    PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/bin"
)