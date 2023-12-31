/*
 *
 * This sample demonstrates how to convert the first page of a PDF document into a JPG image.
 * Copyright (c) 2023, Datalogics, Inc. All rights reserved.
 *
 */

using Datalogics.PDF2IMG;

using (PDF2IMG pdf2img = new PDF2IMG())
{
    ImageConversionOptions options = new ImageConversionOptions();
    options.OutputType = OutputType.JPEG;

    uint numPages = pdf2img.LoadInput("../Sample_Input/input.pdf");

    pdf2img.SetImageConversionOptions(options);

    pdf2img.ConvertPageToImage(1, "ConvertToJpg-output.jpg");
}
