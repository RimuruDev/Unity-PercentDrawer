// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   For Project: "Murders Drones Endless Way".
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using UnityEditor;
using UnityEngine;

namespace AbyssMoth
{
    /// <summary>
    /// Custom property drawer for percentage fields. 
    /// This drawer will display a float property as a slider followed by a percentage label.
    /// </summary>
    [CustomPropertyDrawer(typeof(PercentageAttribute))]
    public class PercentDrawer : PropertyDrawer
    {
        // Supported percentage of width for displaying percent text.
        private const float PercentageWidthFactor = 0.2f;

        // The maximum absolute width of the percent text.
        private const float MaxPercentageWidth = 50f;

        // The indentation between the slider and the percent text.
        private const float FieldPadding = 5f;

        /// <summary>
        /// Overrides the OnGUI method to draw a slider and percentage label in one line.
        /// </summary>
        /// <param name="position">The rectangle on the screen to use for the property GUI.</param>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <param name="label">The label of this property.</param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Ensure the property is a float, otherwise display a warning.
            if (property.propertyType != SerializedPropertyType.Float)
            {
                EditorGUI.LabelField(position, label.text, "Use [Percentage] with float.");
                return;
            }

            // Begin the property GUI block.
            EditorGUI.BeginProperty(position, label, property);

            // Calculate the width of the percentage label as the lesser of the fixed max width or a factor of the total width.
            var percentageWidth = Mathf.Clamp(MaxPercentageWidth, 0f, position.width * PercentageWidthFactor);

            // Adjust the slider's position and width to make room for the percentage label.
            var sliderPosition = position;
            sliderPosition.width -= percentageWidth + FieldPadding;

            // Draw the slider and update the property's value.
            var value = property.floatValue;
            value = EditorGUI.Slider(sliderPosition, label, value, 0f, 1f);
            property.floatValue = value;

            // Set the percentage label's position to immediately follow the slider.
            var percentagePosition = new Rect(sliderPosition.xMax + FieldPadding, position.y, percentageWidth,
                position.height);

            // Draw the percentage label.
            EditorGUI.LabelField(percentagePosition, (value * 100).ToString("F0") + "%");

            // End the property GUI block.
            EditorGUI.EndProperty();
        }

        /// <summary>
        /// Overrides the GetPropertyHeight to return the standard single line height.
        /// </summary>
        /// <param name="property">The SerializedProperty to get the height for.</param>
        /// <param name="label">The label of this property.</param>
        /// <returns>Returns the height of the property GUI.</returns>
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            // Return the height for a single line property GUI.
            return EditorGUIUtility.singleLineHeight;
        }
    }
}