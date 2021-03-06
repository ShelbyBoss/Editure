﻿namespace Editure.Backend.Editing.EditMode
{
    public interface IEditMode
    {
        bool IsCrop { get; }

        bool IsRatio { get; }

        bool IsWidth { get; }

        bool IsHeight { get; }

        IntSize GetScaleSize(IntSize wanna, IntSize original);

        IntSize GetShowSize(IntSize wanna, IntSize scale);
    }
}
