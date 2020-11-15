<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Project.WebForm1" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>My First Website</title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>

  <link rel="stylesheet" href="Scripts/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" />
    <link href="Icons/all.css" rel="stylesheet" />
    <link href="App_Themes/Theme1/dc.css" rel="stylesheet" />
    <script src="Scripts/jquery.min.js"></script>
  <script src="Scripts/popper.min.js"></script>
  <script src="Scripts/bootstrap.min.js"></script>
 
</head>
<body>
<header>
<nav class="navbar navbar-expand-md bg-dark navbar-dark ">
  <a class="navbar-brand" id="logo" href="#">
  <img id="logo-img" src="Images/dc Logo.png" alt="Website Logo" style="height:auto; width:100%;" />
  </a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#collapsibleNavbar">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="collapsibleNavbar">
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link " href="WebForm1.aspx"><i class="fas fa-home">Home</i></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#features"><i class="fas fa-award">Features</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="#about-us"><i class="fas fa-atlas">About-US</i></a>
      </li>    
      
        <li class="nav-item">
        <a class="nav-link" href="#contact-us"><i class="fas fa-address-card">Contact-US</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="SignUpForm.aspx"><i class="fas fa-user-plus">SignUp</i></a>
      </li>
        <li class="nav-item">
        <a class="nav-link" href="#"><i class="fas fa-sign-in-alt">Login</i></a>
      </li>
    </ul>
  </div>  
</nav>
</header>
<div class="container-fluid">
        <div id="home" >
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                </ol>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img class="d-block w-100" src="Images/Slides.jpg" alt="First slide"/>
                        <div class="carousel-caption d-none d-md-block">
                            <h2>We may Help your Ideas !</h2>
                            <p>...</p>
                        </div>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100" src="Images/Slide_2.jpg" alt="Second slide"/>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100" src="Images/Software-developer.jpg" alt="Third slide"/>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100" src="Images/Software.jpg" alt="Fourth slide"/>
                    </div>

                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>

            </div>
             <div id="events">
        </div>
        <div id="features">
            <h1>Our Features</h1>
            <div class="row">
                <div id="feature-blocks" class="col-sm-6 col-md-6 col-lg-4">
                    <img src="Images/comp.png" alt="logo" />
                    <h2>Metaphors</h2>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing
                        and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s
                        , when an unknown printer took a galley of type
                        and scrambled it to make a type specimen book.
                    </p>
                </div>
                <div id="feature-blocks" class="col-sm-6 col-md-6 col-lg-4">
                    <img src="Images/speech logo.png" alt="logo" />
                    <h2>Activities</h2>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing
                        and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s
                        , when an unknown printer took a galley of type
                        and scrambled it to make a type specimen book.
                    </p>
                </div>
                <div id="feature-blocks" class="col-sm-12 col-md-12 col-lg-4">
                    <img src="Images/brain.png" alt="logo" />
                    <h2>Speeches</h2>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing
                        and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s
                        , when an unknown printer took a galley of type
                        and scrambled it to make a type specimen book.
                    </p>
                </div>
            </div>
        </div>
        <div id="about-us">
            <div class="row">
                <div id="about-us-blocks" class="col-sm-12 col-md-8 col-lg-6">
                    <h2>About Us</h2>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing
                        and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s
                        , when an unknown printer took a galley of type
                        and scrambled it to make a type specimen book.
                    </p>
                </div>
                <div id="about-us-blocks" class="col-sm-12 col-md-4 col-lg-6">
                    <img src="Images/about.jpeg" alt="image like our objective" />
                </div>
            </div>
        </div>
        <div id="contact-us">
            <div class="row">
                <div id="contact-us-blocks" class="col-lg-4">
                    
                        <h2>
                            Contact Us 
                        </h2>
                        <h3>
                            Number :+92340-xxxxxxxx
                        </h3>
                        <h3>
                           Address :Str No. , Area , xbxx Town , Karachi , Pakistan 
                        </h3>
                        
                    </div>
                    <div id="contact-us-blocks" class="col-lg-4">
                        <form class="contact-form col-12">
                            <h2>Give Us FeedBack</h2>
                            <table class="table table-borderless">
                                <tr>
                                    <td>
                                                 <input type="text" placeholder="name" class="form-control-lg"/>
                                     </td>
                                    </tr>
                                <tr>
                                    <td>
                                                 <input type="text" placeholder="email" class="form-control-lg"/>
                                    </td>
                                        </tr>
                                <tr>
                                    <td>
                                        <textarea placeholder="message" id="textarea" class="col-lg-12"></textarea>
                                     </td>
                                    
                           </tr>
                                <tr>
                                    <td>
                                        <button type="submit" id="fdsubmit"class="btn-lg btn-primary">Send Message</button>
                                    </td>
                                </tr>
                                    </table>
                                </form>
                    </div>
                
            </div>
            <footer >


    <!-- Social buttons -->
    <ul class="list-unstyled list-inline text-center">
      <li class="list-inline-item">
        <a class="btn-floating btn-fb mx-1">
          <i class="fab fa-facebook-f"> </i>
        </a>
      </li>
      <li class="list-inline-item">
        <a class="btn-floating btn-tw mx-1">
          <i class="fab fa-twitter"> </i>
        </a>
      </li>
      <li class="list-inline-item">
        <a class="btn-floating btn-gplus mx-1">
          <i class="fab fa-google-plus-g"> </i>
        </a>
      </li>
      <li class="list-inline-item">
        <a class="btn-floating btn-li mx-1">
          <i class="fab fa-linkedin-in"> </i>
        </a>
      </li>
      <li class="list-inline-item">
        <a class="btn-floating btn-dribbble mx-1">
          <i class="fab fa-dribbble"> </i>
        </a>
      </li>
    </ul>
    <!-- Social buttons -->


  <!-- Copyright -->
  <div class="footer-copyright text-center py-3">© 2020 Copyright:
    <a href="WebForm1.apsx">Developerscommunity.com</a>
  </div>
  <!-- Copyright -->

</footer>    
        </div>
    </div>


  
</body>
</html>


