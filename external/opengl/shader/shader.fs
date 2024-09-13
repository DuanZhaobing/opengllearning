#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

uniform float mixValue;

void main()
{
    // Blend texture colors with vertex colors.
    // ----------------------------------------
    // FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0f);

    // linearly interpolate between both tetures (80% container, 20% awesomeface)
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(1.0 - TexCoord.x, TexCoord.y)), mixValue);

}