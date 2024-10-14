# Code Test #

The task of extracting the longest increasing subsequence has been successfully completed.

The solution's business logic is encapsulated within an API, which provides two endpoints for accessing the solution:

1. **GetLongestIncreasingSubSequenceFromInputString**: [https://localhost:7050/CT/GetLongestIncreasingSubSequenceFromInputString](https://localhost:7050/CT/GetLongestIncreasingSubSequenceFromInputString)
2. **GetLongestIncreasingSubSequenceFromFile**: [https://localhost:7050/CT/GetLongestIncreasingSubSequenceFromFile](https://localhost:7050/CT/GetLongestIncreasingSubSequenceFromFile)

Both endpoints accept a string as input in the request body. The first endpoint processes the sequence directly, while the second requires the path to a file containing the input sequence.

The solution has successfully passed all provided test cases, as well as additional test-driven development (TDD) cases. The planned TDD cases are as follows:

1. Get_LI_SubSequence_With_Success_Outcome()
2. Get_LI_SubSequence_With_Invalid_Input_Sequence()
3. Get_LI_SubSequence_With_No_Sequence()
4. Get_LI_SubSequence_With_Entire_Input_As_One_Sequence()
5. Get_LI_SubSequence_From_File()

Code linting, appropriate code commenting, and code coverage reporting have been successfully completed. The code coverage reports are provided below:
![](https://github.com/PrithviRajaM/c3e630b9-aa13-40a9-b365-6c17c4eeaf38/blob/AddTestData/CodeTest_Service/TestCaseScreenshots/CodeTest_CodeCoerage.png)
![](https://github.com/PrithviRajaM/c3e630b9-aa13-40a9-b365-6c17c4eeaf38/blob/AddTestData/CodeTest_Service/TestCaseScreenshots/CodeTest_Coverage_Summary.png)
![](https://github.com/PrithviRajaM/c3e630b9-aa13-40a9-b365-6c17c4eeaf38/blob/AddTestData/CodeTest_Service/TestCaseScreenshots/CodeTest_UnitTestCases.png)

## Swagger execution ##
Execute the application with the below command with in CodeTest_PrithviRajaM > CodeTest_Service.

    dotner run

The url for the swagger page should be accessible through the below url.

    https://localhost:7050/index.html

On the Swagger page, initiate the basic authentication with 

Username: CodeTest

Password: CodeTest

Then trigger the endpoint **/OAuth/token** with grant_type as **client_credentials**

It should generate an bearer token, then authenticate it in Swagger's Authorize page.

Once authenticated, both the endpoints under CT controller should be accessible.
