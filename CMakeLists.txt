cmake_minimum_required(VERSION 3.10)

project(OpenGLTutorial VERSION 1.0)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)

find_package(OpenGL REQUIRED)

# Set GLFW directory
set(GLFW_DIR "${CMAKE_SOURCE_DIR}/external/opengl/glfw")
set(GLFW_INCLUDE_DIR "${GLFW_DIR}/include")
set(GLFW_LIB_DIR "${GLFW_DIR}/lib")
set(GLFW_LIB "glfw3")

# Set GLAD directory
set(GLAD_DIR "${CMAKE_SOURCE_DIR}/external/opengl/glad")
set(GLAD_INCLUDE_DIR "${GLAD_DIR}/include")
set(GLAD_SRC "${GLAD_DIR}/src/glad.c")

# Add source file
set(SOURCES main.cpp 
            "${GLAD_SRC}") 

# Add executable
add_executable(Tutorial "${SOURCES}") 

# Add library
target_link_libraries(Tutorial "${GLFW_LIB_DIR}/glfw3.lib" "${OPENGL_LIBRARIES}") 

# Add include directory
target_include_directories(Tutorial PUBLIC "${GLFW_INCLUDE_DIR}" "${GLAD_INCLUDE_DIR}") 

