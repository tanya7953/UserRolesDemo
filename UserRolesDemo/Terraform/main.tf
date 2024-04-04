
## terraform and providers version
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "3.97.1"
    }
  }
  backend "azurerm" {
    resource_group_name  = "rg-1"
    storage_account_name = "sacuserroles"
    container_name       = "new-container"
    key                  = "terraform.tfstate"
  
  }
  required_version = ">= 1.0.0"
}

provider "azurerm" {
  features {}
  skip_provider_registration = true
}
