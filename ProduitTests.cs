namespace AtelierCITests
{
    [TestClass]
    public class ProduitTests
    {
        [TestMethod]
        public void CalculerRemise_ValidePourcentage_RetourneMontantCorrect()
        {
            // Arrange
            var produit = new Produit { Nom = "TestProduit", Prix = 100 };

            // Act
            var remise = produit.CalculerRemise(10);  // 10% de remise

            // Assert
            Assert.AreEqual(90, remise);
        }

        [TestMethod]
        public void CalculerRemise_InvalidePourcentage_RetourneMontantCorrect()
        {
            // Arrange
            var produit = new Produit { Nom = "TestProduit", Prix = 100 };

            // Act
            var remise = produit.CalculerRemise(10);  // 10% de remise

            // Assert
            Assert.AreEqual(100, remise);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculerRemise_InvalidePourcentage_ThrowsException()
        {
            // Arrange
            var produit = new Produit { Nom = "TestProduit", Prix = 100 };

            // Act
            produit.CalculerRemise(110);  // Ceci devrait déclencher une exception
        }
    }
}

