## Question 1
<p>Our company needs to send out time sensitive and highly personal information to clientele.
Information cannot be a savable format at any time. So no emails, faxes, texts, or anything that
would leave a paper trail. How would you solve this problem and what technologies would you
use? What questions would you ask to further your solution or find a better solution?</p>

- First question is how are they accessing this data, either through a web browser or client application? Can we enforce 
use of access to a SCIF? Outside of using a SCIF, there is no perfect solution to 100% prevent this from happening unless 
you control the terminals and environments, they use to access the data. Will this be possible? If we are accessing the 
data via a web browser in a normal office environment there are three possible solutions. One is to create a PDF that is 
streamed to the users browser to view, with the PDF locked down to only view. Second is to use a reporting tool like 
SSRS or Telerik Reporting to create a report that they can view only on the browser. Third solution is to present the data 
using Adobe Flash. The main vulnerabilities of these three solutions are third party tools to capture streamed data, 
screen shots, and users cell phones capturing data. Ypu can control what leaves the computer with monitoring tools, 
but they will realy only slow down a user not stop them.

## Question 2
<p>Represent a 6 string guitar (standard tuning, only the first 2 fret boards) and a 4 string bass
(standard tuning, only the first 3 frets) in a class structure. Create attributes, elements, functions
and any other components you feel they may have.</p>

1. Consider where they are similar and where they are different.
2. Consider we want to identify if the note from one is equal to the other based on the fret
position and string played.

<p>Please note this doesn’t need to be an executable application , only a collection of classes that
would represent the guitar , the bass in its commonality and its differences.</p>

- Please reference the TunningGuitar folder.

## Question 3
<p>Let's say you have a list of N+1 integers between 1 and N. You know there's at least one
duplicate, but there might be more. For example, if N=3, your list might be 3, 1, 1, 3 or it might
be 1, 3, 2, 2. Print out a number that appears in the list more than once. (That is, in the first
example, you can print '1' or '3' -- you don't have to print both.)</p>
<p>Program Input: A list of numbers between 0 and N, all integers, comma separated.</p>
<p>Program Output: A list of all numbers that are duplicated in the list.</p>

- Please reference the nPlusOne folder.


## Question 4
<p>Develop a javascript / browser application that will count the number of words & lines that have
more than X vowels for Y words in every Z line</p>

<p>**Language:** Code this using Javascript and build a quick UI with a text box</p>

<p>**Example:**</p>
</p>Example Parameter: Words: count every [ 3 ] words, Count words with: [2] or more vowels,
every [2] lines</p>

<p><img src="https://github.com/jbcirs/GuestXCodeTest/VowelsForWords/question4ExampleOutput.jpg" alt="Question 4 Example Output"><p>

<p>__ Result:__  Red is a non-match</br>
Bold is a match</br>
Grey are non-considered lines)</p>
<p>**Screen Output:**</p>
<p>Results: Lines: 4, words: 6</p>

- Please reference the VowelsForWords folder.


## Question 5
<p>Our oil and gas client would like an application to track the depletion of their 5 sites. Each site
has between 2 and 5 wells and each well extracts oil, natural gas, or a combination of the two.
There are many large pieces of equipment that need to be assigned to each well including
things like extractors, storage tanks, office buildings, etc. Each well has been analyzed by oil
and gas engineers and they can determine the reserves before any drilling starts. Each day the
equipment operates, the natural resources are extracted and sent to be refined. Our client will
provide the data similar to the tables below.</p>

a) Model this data using your favorite modeling tool and populate your model with your own
sample/test data.
b) Using the sample / test data and data model you created in 5, create sample
visualizations using bootstrap / javascript / css that will allow our client to quickly see
current reserves, daily extraction, and forecasting of when wells will run dry.

<p>The visualization does not have to be dynamic or functional; a static layout is fine.</p>

- Please reference the OilAndGasClient folder.

