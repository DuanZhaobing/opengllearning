#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // Blend texture colors with vertex colors.
    // ----------------------------------------
    // FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0f);

    // linearly interpolate between both tetures (80% container, 20% awesomeface)
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);

}